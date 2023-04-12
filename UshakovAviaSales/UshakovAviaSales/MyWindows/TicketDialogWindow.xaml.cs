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
using UshakovAviaSales.DataFD;
using UshakovAviaSales.MyWindows;
using static UshakovAviaSales.Classes.DataClass;

namespace UshakovAviaSales.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для TicketDialogWindow.xaml
    /// </summary>
    public partial class TicketDialogWindow : Window
    {
        public int flightingId;
        public int idTicketType;
        public decimal bizPrice;
        public decimal ecoPrice;


        public TicketDialogWindow(int flightId)
        {
            InitializeComponent();
            flightingId = flightId;
            var flight = context.FlightDatas.Where(i => i.idFlight == flightingId).FirstOrDefault();
            var company = context.Companies.Where(i => i.idCompany == flight.idCompany).FirstOrDefault();

            bizPrice = (decimal)flight.BuisinessPrice;
            ecoPrice = (decimal)flight.EconomPrice;
            txtCompany.Text = company.Title;
            txtDateOfFlight.Text = DateTime.Now.ToString();
            txtDesignatorPlane.Text = company.Designator+flight.PlaneNumber;
            txtFlightTime.Text = (flight.FlightTimeDurationInMinutes/60).ToString()+" hours";
            txtPrice.Text = flight.EconomPrice.ToString();

        }
        public bool IsBuisiness { get; set; }


        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            int seatNumber;
            int ticketTyper;

            try
            {
                seatNumber = Int32.Parse(txtSeat.Text);

            }
            catch (Exception)
            {
                bool? mb1 = new CustomMbox("Wrong seat format", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                seatNumber = 0;
                return;
            }

            if (context.Tickets.ToList().Where(i => i.idFlight == flightingId).Any(r => r.Seat == seatNumber))
            {
                bool? mb1 = new CustomMbox("This seat is already taken", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                seatNumber = 0;
                return;
            }

           

            if (IsBuisiness)
            {
                ticketTyper = 2;
            }
            else
            {
                ticketTyper = 1;
            }
            try
            {
                context.Tickets.Add(new Ticket
                {


                    idClient = idClientBase,
                    idFlight = flightingId,
                    DateOfPurchase = DateTime.Now,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    idTicketType = ticketTyper,
                    FlightDescription = CommentTextBox.Text,


                });
                var flight = context.FlightDatas.Where(i => i.idFlight == flightingId).FirstOrDefault();
                var dest = context.Destinations.Where(i => i.idDestination == flight.idDestination).FirstOrDefault();
                dest.Visits = dest.Visits + 1;


                context.SaveChanges();
                bool? mb1 = new CustomMbox("You have bought a ticket", MessageType.Info, MessageButtons.Ok).ShowDialog();

                this.Close();
            }
            catch (Exception)
            {

                bool? mb1 = new CustomMbox("Wrong format", MessageType.Warning, MessageButtons.Ok).ShowDialog();

            }


        }


        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ticketToggle_Click(object sender, RoutedEventArgs e)
        {
            if (IsBuisiness == false)
            {
                txtPrice.Text = bizPrice.ToString();
                IsBuisiness = true;
            }
            else
            {
                txtPrice.Text = ecoPrice.ToString();
                IsBuisiness = false;
            }
        }

        private void datepickerOut_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void datepickerLand_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void buyForAnotherBtn_Click(object sender, RoutedEventArgs e)
        {
            var serv = new TicketForAnotherUser(flightingId);
            serv.Show();

        }
    }
}
