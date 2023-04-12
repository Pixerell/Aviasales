using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
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
using UshakovAviaSales.DataFD;
using UshakovAviaSales.MyWindows;
using static UshakovAviaSales.Classes.DataClass;

namespace UshakovAviaSales.MyPages
{
    //Visibility="{Binding isNotified, Converter={StaticResource InvertBooleanConverter}}"
    /// <summary>
    /// Логика взаимодействия для FlightsPage.xaml
    /// </summary>
    public partial class FlightsPage : Page
    {
        public int flightId;
        public FlightsPage()
        {
            InitializeComponent();
            LvCountryList.ItemsSource = context.Destinations.OrderByDescending(x => x.Visits).Take(5).ToList(); 
            LvFlightList.ItemsSource = context.FlightDatas.ToList();
            List<FlightData> destinations = context.FlightDatas.ToList();
            destinations.Insert(0, new FlightData() { idFlight = 0 });

            List<FlightData> destinations1 = context.FlightDatas.ToList();
            destinations1.Insert(0, new FlightData() { idFlight = 0 });

            fromCmb.ItemsSource = context.Destinations.ToList();
            fromCmb.DisplayMemberPath = "Aeroport";
            fromCmb.SelectedIndex = -1;

            toCmb.ItemsSource = context.Destinations.ToList();
            toCmb.DisplayMemberPath = "Aeroport";
            toCmb.SelectedIndex = -1;

            ScrollViewer myScrollViewer = new ScrollViewer();
            myScrollViewer.Content = flightsGrid;
            

        }

        public void Filter()
        {

            var list = context.FlightDatas.ToList();

            if ((bool)onlyAvailableButton.IsChecked)
            {
                list = list.Where(i=>i.DateOfFlight > DateTime.Now).ToList();
                list = list.Where(i => i.isCanceled == false && i.isCanceled != null).ToList();

                LvFlightList.ItemsSource = list;
            }

            if (toCmb.SelectedIndex == -1)
            {
                LvFlightList.ItemsSource = list;
            }
            else
            {
                var Destinations = toCmb.SelectedItem as Destination;
                list = list.Where(i => i.Destination == Destinations).ToList();
                LvFlightList.ItemsSource = list;
            }

            if (datepickerIn.SelectedDate.HasValue)
            {
                if (datepickerIn.SelectedDate.Value < DateTime.Now) {
                    bool mb1 = (bool)new CustomMbox("Date Of Flying Out Cannot Be In The Past!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                    datepickerIn.SelectedDate = null;
                    Filter();
                }
                else
                {
                    list = list.Where(i => i.DateOfFlight == datepickerIn.SelectedDate.Value).ToList();
                    LvFlightList.ItemsSource = list;
                }

            }
            
           
            
            if (fromCmb.SelectedIndex == -1)
            {
                LvFlightList.ItemsSource = list;
            }
            else
            {
                var Destinations = fromCmb.SelectedItem as Destination;
                list = list.Where(i => i.Destination1 == Destinations).ToList();
                LvFlightList.ItemsSource = list;
            }
            
            
            
        }
        public void ClearValues()
        {
            fromCmb.SelectedIndex = -1;
            toCmb.SelectedIndex = -1;
            datepickerIn.SelectedDate = null;
            onlyAvailableButton.IsChecked = false;
            Filter();
        }
        private void resetFiltersBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearValues();

        }

        private void fromCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void toCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();

        }

        private void datepickerIn_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }


        private void LvCountryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LvCountryList.SelectedItem is Destination destination)
            {
                idDestinationel = destination.idDestination;
                var list = context.FlightDatas.
                    Where(f => f.idDestination == idDestinationel).ToList();
                LvFlightList.ItemsSource = list;

            }
        }

        private void LvFlightList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (LvFlightList.SelectedItem is FlightData flightData)
            {
                if (isManager)
                {
                    bool? anwser = new CustomMbox("Are you sure you want to cancel this Flight?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                    if (anwser.Value)
                    {
                        if (flightData.isCanceled == true)
                        {
                            bool? anwser2 = new CustomMbox("This flight is already cancelled, want to restart it?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                            if (anwser2.Value)
                            {
                                flightData.isCanceled = false;
                                bool? mb2 = new CustomMbox("Flight restarted", MessageType.Info, MessageButtons.Ok).ShowDialog();
                            }
                            LvFlightList.ItemsSource = context.FlightDatas.ToList();
                            return;

                        }
                        flightData.isCanceled = true;
                        context.SaveChanges();
                        bool? mb1 = new CustomMbox("Flight Is Cancelled", MessageType.Info, MessageButtons.Ok).ShowDialog();
                        LvFlightList.ItemsSource = context.FlightDatas.ToList();
                        return;
                    }

                }

                if (flightData.isCanceled == true )
                {
                    bool? mb1 = new CustomMbox("Sorry this flight is cancelled", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    return;
                }
                else if (flightData.DateOfFlight < DateTime.Now)
                {
                    bool? mb1 = new CustomMbox("This flight is already happened", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    return;

                }
                flightId = flightData.idFlight;
                TicketDialogWindow ticketDialogWindow = new TicketDialogWindow(flightId);
                ticketDialogWindow.ShowDialog();
                LvFlightList.ItemsSource = context.FlightDatas.ToList();
                ClearValues();
            }

        }

        private void onlyAvailableButton_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }
    }
}
