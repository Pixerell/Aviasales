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

namespace UshakovAviaSales.MyPages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private MainWindow main;
        public ProfilePage(MainWindow mainWindow)
        {
            InitializeComponent();

            main = mainWindow;


            ScrollViewer myScrollViewer = new ScrollViewer();
            myScrollViewer.Content = profileInfoGrid;

            var client = context.Clients.Where(i => i.idClient == idClientBase).FirstOrDefault();
            LvTicketList.ItemsSource = context.Tickets.Where(i => i.idClient == idClientBase).ToList();
            var user = context.Users.Where(i => i.idUser == client.idUser).FirstOrDefault();
            var role = context.Roles.Where(i => i.idRole == user.idRole).FirstOrDefault();

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

            txtFirstname.Text = client.FirstName;
            txtPatronymic.Text = client.Patronymic;
            txtSurname.Text = client.LastName;
            txtPass.Password = user.Password;
            txtUser.Text = user.Login;
            txtRole.Text = role.RoleName;
            datepickerBirthday.SelectedDate = client.Birthday;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            txtPassNumber.Text = client.PassportNumber.ToString();
            txtPassSeries.Text = client.PassportSeries.ToString();

            if (client.GenderCode == "ж") cmbGender.SelectedIndex = 0;
            else cmbGender.SelectedIndex = 1;

            if (client.intPassportType == 1) cmbPassType.SelectedIndex = 0;
            else cmbPassType.SelectedIndex = 1;

            if (isManager) checkAllClientsBtn.Visibility = Visibility.Visible;

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = context.Clients.Where(i => i.idClient == idClientBase).FirstOrDefault();
                var user = context.Users.Where(i => i.idUser == client.idUser).FirstOrDefault();
                var role = context.Roles.Where(i => i.idRole == user.idRole).FirstOrDefault();

                client.FirstName = txtFirstname.Text;
                client.Patronymic = txtPatronymic.Text;
                client.LastName = txtSurname.Text;
                user.Password = txtPass.Password;
                user.Login = txtUser.Text;
                role.RoleName = txtRole.Text;

                if (datepickerBirthday.SelectedDate.HasValue && datepickerBirthday.SelectedDate.Value > DateTime.Now)
                {
                    bool mb1 = (bool)new CustomMbox("Date Of Birthday Out Cannot Be In The Future!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                    return;
                }
                else if (datepickerBirthday.SelectedDate.HasValue && datepickerBirthday.SelectedDate.Value.AddYears(14) > DateTime.Now)
                {
                    bool mb1 = (bool)new CustomMbox("You are not old enough to have a PassPort", MessageType.Warning, MessageButtons.Ok).ShowDialog();
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
                    return;
                }

                if (txtPhone.Text.Length > 20)
                {
                    bool mb1 = (bool)new CustomMbox("Phone field is too long! 20 charactes max.", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                    return;

                }


                client.Birthday = (DateTime)datepickerBirthday.SelectedDate;

                client.Email = txtEmail.Text;
                client.Phone = txtPhone.Text;
                client.PassportNumber = Int32.Parse(txtPassNumber.Text);
                client.PassportSeries = Int32.Parse(txtPassSeries.Text);
                if (cmbGender.SelectedIndex == 0) client.GenderCode = "ж";
                else client.GenderCode = "м";

                if (cmbPassType.SelectedIndex == 0) client.intPassportType = 1;
                else client.intPassportType = 2;

                context.SaveChanges();
                bool? mb2 = new CustomMbox("Data saved", MessageType.Success, MessageButtons.Ok).ShowDialog();

            }
            catch (Exception)
            {
                bool? mb1 = new CustomMbox("Wrong Format", MessageType.Warning, MessageButtons.Ok).ShowDialog();

            }



        }

        private void LvTicketList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LvTicketList.SelectedItem is Ticket tickets)
            {
                try
                {
                    TicketInfo ticketDialogWindow = new TicketInfo(tickets.idTicket);
                    ticketDialogWindow.ShowDialog();
                }
                catch (Exception)
                {


                    context.Tickets.Remove(context.Tickets.Where(i => i.idTicket == tickets.idTicket).FirstOrDefault());
                    context.SaveChanges();
                    LvTicketList.ItemsSource = context.Tickets.Where(i => i.idClient == idClientBase).ToList();


                }
                

            }
        }

        private void datepickerBirthday_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.log = null;
            Properties.Settings.Default.pass = null;
            Properties.Settings.Default.Save();

            if (main != null)
            {
                LoginWindow log = new LoginWindow();
                log.Show();
                main.Close();

            }
          //  Application.Current.Shutdown();
        }

        private void checkAllClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.ShowDialog();
        }
    }
}
