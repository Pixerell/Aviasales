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
    /// Логика взаимодействия для TicketInfo.xaml
    /// </summary>
    public partial class TicketInfo : Window
    {
        public int ticketsId;

        public TicketInfo(int ticketIdino)
        {
            InitializeComponent();
            try
            {
                ticketsId = ticketIdino;
                
                var tick = context.Tickets.Where(i => i.idTicket == ticketIdino).FirstOrDefault();
                var flight = context.FlightDatas.Where(i => i.idFlight == tick.idFlight).FirstOrDefault();
                var tickType = context.TicketTypes.Where(i => i.idTicketType == tick.idTicketType).FirstOrDefault();
                var company = context.Companies.Where(i => i.idCompany == flight.idCompany).FirstOrDefault();

                txtCompany.Text = company.Title;
                txtDateOfFlight.Text = DateTime.Now.ToString();
                txtDesignatorPlane.Text = company.Designator + flight.PlaneNumber;
                txtFlightTime.Text = (flight.FlightTimeDurationInMinutes / 60).ToString() + " hours";
                txtPrice.Text = tick.Price.ToString();
                txtSeatNumber.Text = tick.Seat.ToString();
                txtDateOfPurchase.Text = tick.DateOfPurchase.ToString();
                txtTicketType.Text = tickType.Type;
                txtComment.Text = tick.FlightDescription.ToString();
                txtId.Text = tick.idTicket.ToString();
            }
            catch (Exception)
            {

                bool? mb1 = new CustomMbox("Sorry, you can't access that information", MessageType.Error, MessageButtons.Ok).ShowDialog();
                this.Close();
            }

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void closeNBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
