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
    /// Логика взаимодействия для ClientInfo.xaml
    /// </summary>
    public partial class ClientInfo : Window
    {
        public ClientInfo(int passedId)
        {
            InitializeComponent();

            var client = context.Clients.Where(i => i.idClient == passedId).FirstOrDefault();
            var user = context.Users.Where(i => i.idUser == client.idUser).FirstOrDefault();

            List<Gender> genders = context.Genders.ToList();
            genders.Insert(0, new Gender() { Code = "ж" });

            List<PassportType> passportTypes = context.PassportTypes.ToList();
            passportTypes.Insert(0, new PassportType() { idPassportType = 0 });

            txtFirstname.Text = client.FirstName;
            txtPatronymic.Text = client.Patronymic;
            txtSurname.Text = client.LastName;
            txtPass.Password = user.Password;
            txtUser.Text = user.Login;
            clientBirthdate.SelectedDate = client.Birthday;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            txtPassNumber.Text = client.PassportNumber.ToString();
            txtPassSeries.Text = client.PassportSeries.ToString();

            if (client.GenderCode == "ж") txtGender.Text = "Женский";
            else txtGender.Text = "Мужской";

            if (client.intPassportType == 1) txtPassType.Text = "Заграничный";
            else txtPassType.Text = "Внутренний";
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
