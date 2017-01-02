using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Network_Tools
{
    class Labels
    {
        /// <summary>
        /// This class runs every second. It pings all of the addresses on the main screen, and then updates the response time to match the results.
        /// </summary>
        /// <param name="_grid"></param>
        public static void Update(Grid _grid)
        {
            // Get all of the labels in the Grid
            var labels = Cards.GetLabels(_grid);
            var times = PingNetwork.SendMultipleAsync(labels);

            for (var i = 0; i < labels.Count; i++)
            {
                var currentLabel = labels[i];
                var currentTime = times[i];

                Debug.WriteLine($"Roundtrip Time: {currentTime.RoundtripTime}, Status: {currentTime.IpStatus.ToString()}");

                if (currentTime.IpStatus != IPStatus.Success || currentTime == null)
                {
                    currentLabel.responseLabel.Content = $"Timed Out";
                }

                else
                {
                    currentLabel.responseLabel.Content = $"{currentTime.RoundtripTime.ToString()} ms";
                }

            }

            Debug.WriteLine("-");
        }
    }

    class UpdateThread
    {
        public static void Start(Grid _grid)
        {
        }
    }
}
