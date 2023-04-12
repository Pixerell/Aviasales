using System.Linq;
using System.Windows;
using System.Windows.Controls;
using UshakovAviaSales.MyWindows;
using UshakovAviaSales.DataFD;
using static UshakovAviaSales.Classes.DataClass;
using UshakovAviaSales.Classes;
using System;

namespace UshakovAviaSales.MyPages
{
    public partial class NotificationsPage : Page
    {
        public NotificationsPage()
        {
            InitializeComponent();
            var noti = context.Notifications.Where(i => i.idClient == idClientBase).ToList();
            if (noti.Any() == false) {
                gridNoNotifications.Visibility = Visibility.Visible;
                gridHaveNotifications.Visibility = Visibility.Hidden;
                    }
            else
            {
                gridHaveNotifications.Visibility=Visibility.Visible;
                gridNoNotifications.Visibility=Visibility.Hidden;
                LvNotificationsList.ItemsSource = noti;

            }
        }

        public bool isNotified { get; set; }


        private void LvNotificationsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LvNotificationsList.SelectedItem is Notification notifications)
            {
                bool? anwser = new CustomMbox("Do you really want to disable this notification?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();

                if (anwser.Value)
                {

                    context.Notifications.Remove(context.Notifications.Where(i => i.idNotification == notifications.idNotification).FirstOrDefault());
                    context.SaveChanges();
                    bool? mb1 = new CustomMbox("Notification disabled", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    LvNotificationsList.ItemsSource = context.Notifications.ToList();

                }

            }
        }

        private void notificationAddBtn_Click(object sender, RoutedEventArgs e)
        {
            NotificationDialogWindow notificationDialog = new NotificationDialogWindow();
            notificationDialog.ShowDialog();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var client = context.Clients.FirstOrDefault(r => r.idClient == DataClass.idClientBase);

            var notifications = client.Notifications
                .Where(r => r.Status.HasValue && !r.Status.Value);

            foreach (var notification in notifications)
            {
                var oldPrice = notification.Price;
                //api
                var result4 = await API.Client.GetHotelById(notification.HotelId);
                decimal newPrice;
                if (result4 == null)
                {
                     newPrice = oldPrice;

                }
                else
                {
                     newPrice = (decimal)result4.maxrate;

                }

                switch (notification.idPriceCheck)
                {
                    case 1:
                        if (oldPrice > (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    case 2:
                        if (oldPrice < (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    case 3:
                        if (oldPrice == (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    default:
                        break;
                }

            }
            var noti = context.Notifications.Where(i => i.idClient == idClientBase).ToList();
            LvNotificationsList.ItemsSource = noti;
        }

        private async void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            LvNotificationsList = null;
            var client = context.Clients.FirstOrDefault(r => r.idClient == DataClass.idClientBase);

            var notifications = client.Notifications
                .Where(r => r.Status.HasValue && !r.Status.Value);

            foreach (var notification in notifications)
            {
                var oldPrice = notification.Price;
                var newPrice = 1.00;

                //api
                var result4 = await API.Client.GetHotelById(notification.HotelId);
                try
                {
                    newPrice = result4.maxrate;

                }
                catch (Exception)
                {

                    newPrice = (float)oldPrice;
                }
                //var newPrice = result4.maxrate;

                switch (notification.idPriceCheck)
                {
                    case 1:
                        if (oldPrice > (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    case 2:
                        if (oldPrice < (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    case 3:
                        if (oldPrice == (decimal)newPrice)
                        {
                            notification.Status = true;
                            notification.DateOfNotifying = DateTime.Now;
                            context.SaveChanges();
                        }
                        break;
                    default:
                        break;
                }
            }
            var noti = context.Notifications.Where(i => i.idClient == idClientBase).ToList();
            LvNotificationsList.ItemsSource = noti;
        }
    }
}
