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
using static UshakovAviaSales.Classes.DataClass;

namespace UshakovAviaSales.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для NotificationDialogWindow.xaml
    /// </summary>
    public partial class NotificationDialogWindow : Window
    {
        public int checkSelected;
        public NotificationDialogWindow(string hotelinoIdino = "0")
        {
            InitializeComponent();
            if (hotelinoIdino != "0") apiCall(hotelinoIdino);
        }

        private void setNotificationBtn_Click(object sender, RoutedEventArgs e)
        {
            if (moreBtn.IsChecked == true) checkSelected = 1;
            else if (equalBtn.IsChecked == true) checkSelected = 3;
            else if (lessBtn.IsChecked == true) checkSelected = 2;
            else
            {
                bool mb1 = (bool)new CustomMbox("Check atleast one button!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
            }

            try
            {
                int b = Int32.Parse(txtHotelId.Text);
                decimal a = Int32.Parse(txtPrice.Text);
            }
            catch (Exception)
            {

                bool mb1 = (bool)new CustomMbox("Hotel Id and Price fields only accept numbers!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
            }

            try
            {
                context.Notifications.Add(new Notification
                {

                    DateSet = DateTime.Now,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    idClient = idClientBase,
                    AdditionalInformation = txtComment.Text,
                    idPriceCheck = checkSelected,
                    HotelId = Int32.Parse(txtHotelId.Text),
                    Status = false,

                });

                context.SaveChanges();
                bool? mb1 = new CustomMbox("You have set a notification", MessageType.Info, MessageButtons.Ok).ShowDialog();

                this.Close();
            }
            catch (Exception)
            {
                bool? mb1 = new CustomMbox("Wrong Format", MessageType.Warning, MessageButtons.Ok).ShowDialog();

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

        private async void apiCall(string ide)
        {

                var result3 = await API.Client.GetHotelById(Int32.Parse(ide));
            txtHotelId.Text = result3.hotel_id.ToString();
            txtComment.Text = result3.url;
            txtPrice.Text = result3.maxrate.ToString();
           

        }
    }
}
