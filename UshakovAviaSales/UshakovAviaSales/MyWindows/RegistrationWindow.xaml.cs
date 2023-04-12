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

namespace UshakovAviaSales.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();

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

        private void datepickerBirthdate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            var serv = new LoginWindow();
            serv.Show();
            this.Close();
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {

            if (datepickerBirthdate.SelectedDate.HasValue && datepickerBirthdate.SelectedDate.Value > DateTime.Now)
            {
                bool mb1 = (bool)new CustomMbox("Date Of Birthday Out Cannot Be In The Future!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                datepickerBirthdate.SelectedDate = null; 
                return;
            }
            else if (datepickerBirthdate.SelectedDate.HasValue && datepickerBirthdate.SelectedDate.Value.AddYears(14) > DateTime.Now)
            {
                bool mb1 = (bool)new CustomMbox("You are not old enough to have a PassPort", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            try
            {
                int b = Int32.Parse(txtPassSeries.Text);
                int a  = Int32.Parse(txtPassNumber.Text);
            }
            catch (Exception)
            {

                bool mb1 = (bool)new CustomMbox("Passport series and number only accept numbers", MessageType.Warning, MessageButtons.Ok).ShowDialog();
            }

                if (txtPhone.Text.Length > 20)
                {
                bool mb1 = (bool)new CustomMbox("Phone field is too long! 20 charactes max.", MessageType.Warning, MessageButtons.Ok).ShowDialog();

                  }



            try
            {
                var user = new User
                {
                    Login = txtUser.Text,
                    Password = txtPass.Password,
                    idRole = 1,
                };

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
                    User = user
                };

                context.Clients.Add(client);
                context.SaveChanges();

                bool? mb1 = new CustomMbox($"Client {txtFirstname.Text} {txtSurname.Text} Has Been Added", MessageType.Info, MessageButtons.Ok).ShowDialog();


                this.Close();
            }
            catch (Exception)
            {

                bool mb1 = (bool)new CustomMbox("Wrong Format. Try Again", MessageType.Warning, MessageButtons.Ok).ShowDialog();

                return;
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool? mb1 = new CustomMbox("Phone and Patronymic are not required too sign up, everything else is.", MessageType.Info, MessageButtons.Ok).ShowDialog();

        }
    }
}
