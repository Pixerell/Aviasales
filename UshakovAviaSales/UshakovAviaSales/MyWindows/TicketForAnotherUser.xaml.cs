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
using UshakovAviaSales.DataFD;
using UshakovAviaSales.MyWindows;
using static UshakovAviaSales.Classes.DataClass;

namespace UshakovAviaSales.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для TicketForAnotherUser.xaml
    /// </summary>
    public partial class TicketForAnotherUser : Window
    {
        public int flightingId;
        public int idTicketType;
        public decimal bizPrice;
        public decimal ecoPrice;
        public string creatingLog;

        public TicketForAnotherUser(int flightIdentity)
        {
            InitializeComponent();
            flightingId = flightIdentity;
            var flight = context.FlightDatas.Where(i => i.idFlight == flightingId).FirstOrDefault();
            var company = context.Companies.Where(i => i.idCompany == flight.idCompany).FirstOrDefault();
            var clientCreating = context.Clients.Where(i => i.idClient == idClientBase).FirstOrDefault();
            var userCreating = context.Users.Where(i => i.idUser == clientCreating.idUser).FirstOrDefault();

            creatingLog = userCreating.Login;

            bizPrice = (decimal)flight.BuisinessPrice;
            ecoPrice = (decimal)flight.EconomPrice;
            txtCompany.Text = company.Title;
            txtDateOfFlight.Text = DateTime.Now.ToString();
            txtDesignatorPlane.Text = company.Designator + flight.PlaneNumber;
            txtFlightTime.Text = (flight.FlightTimeDurationInMinutes / 60).ToString() + " hours";
            txtPrice.Text = flight.EconomPrice.ToString();

            List<Gender> genders = context.Genders.ToList();
            genders.Insert(0, new Gender() { Code = "ж" });

            cmbGender.ItemsSource = context.Genders.ToList();
            cmbGender.DisplayMemberPath = "Name";
            cmbGender.SelectedIndex = 0;

            List<PassportType> passportTypes = context.PassportTypes.ToList();
            passportTypes.Insert(0, new PassportType() { idPassportType = 0 });

            cmbPassType.ItemsSource = context.PassportTypes.ToList();
            cmbPassType.DisplayMemberPath = "PassportType1";
            cmbPassType.SelectedIndex = 0;
        }

        public bool IsBuisiness { get; set; }



        private void buyForAnotherBtn_Click(object sender, RoutedEventArgs e)
        {
            int seatNumber;
            int ticketTyper;

            try
            {
                seatNumber = Int32.Parse(txtSeat.Text);

            }
            catch (Exception)
            {
                bool? mb1 = new CustomMbox("Wrong Seat format", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                seatNumber = 0;
                return;
            }

            if (context.Tickets.ToList().Where(i => i.idFlight == flightingId).Any(r => r.Seat == seatNumber))
            {
                bool? mb1 = new CustomMbox("This Seat is already taken", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                seatNumber = 0;
                return;
            }

            if (datepickerBirthdate.SelectedDate.HasValue && datepickerBirthdate.SelectedDate.Value > DateTime.Now)
            {
                bool mb1 = (bool)new CustomMbox("Date Of Birthday Out Cannot Be In The Future!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                datepickerBirthdate.SelectedDate = null;
                return;
            }
            else if (datepickerBirthdate.SelectedDate.HasValue && datepickerBirthdate.SelectedDate.Value.AddYears(14) > DateTime.Now)
            {
                bool mb1 = (bool)new CustomMbox("Not old enough to have a PassPort", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            try
            {
                int b = Int32.Parse(txtPassSeries.Text);
                int a = Int32.Parse(txtPassNumber.Text);
            }
            catch (Exception)
            {

                bool mb1 = (bool)new CustomMbox("Passport series and number only accept numbers", MessageType.Warning, MessageButtons.Ok).ShowDialog();
            }

            if (txtPhone.Text.Length > 20)
            {
                bool mb1 = (bool)new CustomMbox("Phone field is too long! 20 charactes max.", MessageType.Warning, MessageButtons.Ok).ShowDialog();

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
                var client = new Client
                {
                    LastName = txtSurname.Text,
                    FirstName = txtFirstname.Text,
                    Patronymic = txtPatronymic.Text,
                    PassportSeries = Int32.Parse(txtPassSeries.Text),
                    PassportNumber = Int32.Parse(txtPassNumber.Text),
                    Birthday = datepickerBirthdate.SelectedDate.Value,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Gender = (Gender)cmbGender.SelectedItem,
                    PassportType = (PassportType)cmbPassType.SelectedItem,
                };
                var ticket = new Ticket
                {
                    idFlight = flightingId,
                    DateOfPurchase = DateTime.Now,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    idTicketType = ticketTyper,
                    FlightDescription = "Ticket Purchased By Another Person. ID - " + idClientBase + ". Login - " + creatingLog,
                    Client = client,
                };


                var flight = context.FlightDatas.Where(i => i.idFlight == flightingId).FirstOrDefault();
                var dest = context.Destinations.Where(i => i.idDestination == flight.idDestination).FirstOrDefault();
                dest.Visits = dest.Visits + 1;

                context.Tickets.Add(ticket);

                context.SaveChanges();
                bool? mb1 = new CustomMbox("You have bought a ticket for another user", MessageType.Info, MessageButtons.Ok).ShowDialog();

                this.Close();
            }
            catch (Exception)
            {

                bool? mb1 = new CustomMbox("Wrong format", MessageType.Warning, MessageButtons.Ok).ShowDialog();

            }


        }

        private void goBackToTicketsBtn_Click(object sender, RoutedEventArgs e)
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

        private void datepickerBirthdate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
