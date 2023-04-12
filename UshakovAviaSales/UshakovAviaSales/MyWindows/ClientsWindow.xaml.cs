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
    /// Логика взаимодействия для ClientsWindow.xaml
    /// </summary>
    public partial class ClientsWindow : Window
    {
        public ClientsWindow()
        {
            InitializeComponent();
            ScrollViewer myScrollViewer = new ScrollViewer();
            myScrollViewer.Content = clientsGrid;

            List<Ticket> tickets = context.Tickets.ToList();
            tickets.Insert(0, new Ticket() { idTicket = 0 });

            ticketCmb.ItemsSource = tickets;
           ticketCmb.DisplayMemberPath = "idTicket";
            ticketCmb.SelectedIndex = -1;


            LvAllClients.ItemsSource = context.Clients.ToList();
        }
        public void Filter()
        {
            var list = context.Clients.Where(i => i.Email.ToLower().Contains(txtLogs.Text)).ToList();
            LvAllClients.ItemsSource = context.Clients.ToList();

            if (ticketCmb.SelectedIndex == 0 || ticketCmb.SelectedIndex == -1)
            {
                LvAllClients.ItemsSource = list;
            }
            else
            {
                try
                {
                    var ticketsSelected = ticketCmb.SelectedItem as Ticket;
                    var listTickets = context.Clients.Where(i => i.idClient == ticketsSelected.idClient).ToList();

                    LvAllClients.ItemsSource = listTickets;
                }
                catch (Exception)
                {
                    bool? mb1 = new CustomMbox("Could not conver data", MessageType.Error, MessageButtons.Ok).ShowDialog();
                    txtLogs.Text = null;
                    ticketCmb.SelectedIndex = -1;

                }

            }

        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LvAllClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LvAllClients.SelectedItem is Client client)
            {
               
                ClientInfo clientInfo = new ClientInfo(client.idClient);
                clientInfo.ShowDialog();
                LvAllClients.ItemsSource = context.Clients.ToList();
            }

        }

        private void ticketCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void txtLogs_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
    }
}
