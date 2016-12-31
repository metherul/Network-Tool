using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Network_Tools
{
    class Cards
    {
        public static void AddCard(Grid _grid, string _ipAddress)
        {
            var items = _grid.Children.OfType<Card>();
            var placementLocation = 0;
            var itemCount = items.Count();
            var ipAddress = _ipAddress;

            placementLocation = (itemCount * 28);

            Grid grid = new Grid();

            Label label = new Label
            {
                FontSize = 14,
                FontFamily = new FontFamily("Roboto"),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                Name = $"addressName_{itemCount}",
                Content = ipAddress
            };

            grid.Children.Add(label);

            label = new Label
            {
                FontSize = 14,
                FontFamily = new FontFamily("Roboto"),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 90, 0),
                Name = $"responseTime_{itemCount}",
                Content = "-"
            };

            grid.Children.Add(label);

            PackIcon icon = new PackIcon
            {
                Kind = PackIconKind.Earth,
                Height = double.NaN,
                Width = double.NaN,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            Button button = new Button
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                Content = icon
            };

            grid.Children.Add(button);

            Card card = new Card
            {
                Margin = new Thickness(5, placementLocation, 5, 5),
                Padding = new Thickness(8, 8, 8, 8),
                Content = grid
            };

            card.SetResourceReference(Control.BackgroundProperty, "PrimaryHueLightBrush");
            card.SetResourceReference(Control.ForegroundProperty, "PrimaryHueLightForegroundBrush");

            _grid.Children.Add(card);
        }

        public static void UpdatePings(Grid _grid)
        {
            List<long> times = new List<long>();
            List<LabelData> labels = new List<LabelData>();

            foreach (var card in _grid.Children.OfType<Card>())
            {
                Grid grid = (Grid)card.Content;
                var gridLabels = grid.Children.OfType<Label>();

                // Get Addresses and Response Times from Cards
                foreach (var item in gridLabels)
                {
                    LabelData labelData = new LabelData();

                    if (item.Name.StartsWith("addressName"))
                    {
                        labelData.addressLabel = item;
                        Debug.WriteLine($"Address Name: {item.Name.ToString()}");
                    }

                    if (item.Name.StartsWith("responseTime"))
                    {
                        labelData.responseLabel = item;
                        Debug.WriteLine($"Response Times: {item.Name.ToString()}");
                    }

                    labels.Add(labelData);
                }
            }

            Debug.WriteLine("-");

            foreach (var label in labels)
            {
                var pingResponse = PingNetwork.Send(label.addressLabel.Content.ToString());

                if (pingResponse.IpStatus == IPStatus.Success)
                {
                    label.responseLabel.Content = pingResponse.RoundtripTime;
                }

                else
                {
                    label.responseLabel.Content = "Timed Out";
                }
            }

            _grid.InvalidateVisual();
        }
    }

    class LabelData
    {
        public Label addressLabel { get; set; }
        public Label responseLabel { get; set; }
    }
}
