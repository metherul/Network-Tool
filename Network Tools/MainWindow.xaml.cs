using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Network_Tools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UpdateThread.Start(itemCanvas_Grid);
        }

        private void closeWindow_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void minimizeWindow_Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void addIP_Button_Click(object sender, RoutedEventArgs e)
        {
            selectIP_DialogWindow.IsOpen = true;
        }

        private void saveIP_Button_Click(object sender, RoutedEventArgs e)
        {
            selectIP_DialogWindow.IsOpen = false;

            if (dialogWindow_TextBox.Text != string.Empty)
                Cards.AddCard(itemCanvas_Grid, dialogWindow_TextBox.Text);

            if (itemCanvas_Grid.Children.OfType<Card>().Count() > 0)
            {
                notificationText_Label.Visibility = Visibility.Hidden;
                notificationIcon_PackIcon.Visibility = Visibility.Hidden;
            }

            else if (itemCanvas_Grid.Children.OfType<Card>().Count() == 0)
            {
                notificationText_Label.Visibility = Visibility.Visible;
                notificationIcon_PackIcon.Visibility = Visibility.Visible;
            }

            dialogWindow_TextBox.Text = null;

            // Labels.Update(itemCanvas_Grid);

        }

        private void cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            selectIP_DialogWindow.IsOpen = false;
            dialogWindow_TextBox.Text = null;

        }
    }
}
