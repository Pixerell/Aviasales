using System;
using System.Collections.Generic;
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

namespace UshakovAviaSales
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MyPages.FlightsPage());
            flightIcon.Foreground = new SolidColorBrush(Color.FromRgb(255,   87,  51));

        }

        private void ClearValues()
        {
            notificationsIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            flightIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            profileIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            searchIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.HotelsPage());
            ClearValues();
            searchIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 87, 51));
        }

        private void flightBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.FlightsPage());
            ClearValues();
            flightIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 87, 51));
        }

        private void notificationsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.NotificationsPage());
            ClearValues();
            notificationsIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 87, 51));
        }

        private void accountBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.ProfilePage(this));
            ClearValues();
            profileIcon.Foreground = new SolidColorBrush(Color.FromRgb(255, 87, 51));
        }

        private void dragBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
