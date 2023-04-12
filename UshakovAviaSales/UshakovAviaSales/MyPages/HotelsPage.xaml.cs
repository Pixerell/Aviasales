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
using System.Windows.Shapes;
using UshakovAviaSales.Classes;
using UshakovAviaSales.DataFD;
using UshakovAviaSales.MyWindows;
using static UshakovAviaSales.Classes.DataClass;

namespace UshakovAviaSales.MyPages
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public string hotelCheckId;
        public HotelsPage()
        {
            InitializeComponent();
            ScrollViewer myScrollViewer = new ScrollViewer();
            myScrollViewer.Content = hotelsGrid;
            // myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            List<City> cities = context.Cities.ToList();
            cities.Insert(0, new City() { idCity = 0 });

            cityCmb.ItemsSource = cities;
            cityCmb.DisplayMemberPath = "CityName";
            cityCmb.Text = "Default City";
           // cityCmb.SelectedIndex = 0;


        }

        private async void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cityCmb.Text) || cityCmb.Text == "Default City")
            {
                bool? mb1 = new CustomMbox("Select a city", MessageType.Info, MessageButtons.Ok).ShowDialog();

            }
            else
            {
                var result = await API.Client.GetDestId(cityCmb.Text);

                var results = await API.Client.GetHotels(result);

                API.Results = results;

                LVHotels.ItemsSource = API.Results;
                if (LVHotels.ItemsSource == null || results.Count == 0)
                {
                    bool? mb1 = new CustomMbox("No hotels for that city, sorry...", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    return;
                }

            }

        }

        private async void cityCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cityCmb.Text))
            {
                bool? mb1 = new CustomMbox("Text accepted, try clicking the check button.", MessageType.Success, MessageButtons.Ok).ShowDialog();


            }
            else
            {
                bool? mb1 = new CustomMbox("No hotels for that city, sorry...", MessageType.Info, MessageButtons.Ok).ShowDialog();
            }

        }

        private async void LVHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 14

            if (LVHotels.SelectedItem is Result result)
            {
                hotelCheckId = result.hotel_id.ToString();
               // hotelCheckId.Remove(0, 13);

                NotificationDialogWindow notificationDialog = new NotificationDialogWindow(hotelCheckId);
                notificationDialog.ShowDialog();
            }

        }
    }
}
