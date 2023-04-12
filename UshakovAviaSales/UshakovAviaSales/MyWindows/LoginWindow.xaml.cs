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
using static UshakovAviaSales.Classes.DataClass;

using MaterialDesignThemes.Wpf;
using UshakovAviaSales.Classes;
using System.Net.Http;

namespace UshakovAviaSales.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        

        public LoginWindow()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.log))
            {
                txtUser.Text = Properties.Settings.Default.log;
                txtPassword.Password = Properties.Settings.Default.pass;
                var tmp = context.Users.Where(b => b.Login == txtUser.Text).FirstOrDefault();
                var tmp1 = context.Clients.Where(j => j.idUser == tmp.idUser).FirstOrDefault();
                idClientBase = tmp1.idClient;
                if (tmp.idRole == 2 || tmp.idRole == 3) isManager = true;

                var serv = new MainWindow();
                serv.Show();
                this.Close();
            }
            txtUser.Text = "IvanZolo";
            txtPassword.Password = "A111222B";
        }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void themeToggle_Click(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme= true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!HelperClass.IsAllTextFieldsFill(this))
            {
                bool? mb1 = new CustomMbox("Type in all fields please", MessageType.Info, MessageButtons.Ok).ShowDialog();

                return;
            }
            

            var login = txtUser.Text;
            var pass = txtPassword.Password;
            var tmp = context.Users.Where(b => b.Login == login).FirstOrDefault();
            if (tmp == null)
            {
                bool? mb1 = new CustomMbox("User Not Found", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            if (pass != tmp.Password)
            {
                bool? mb1 = new CustomMbox("Wrong Password", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            var tmp1 = context.Clients.Where(j=>j.idUser == tmp.idUser).FirstOrDefault();
            idClientBase = tmp1.idClient;

            if (rememberCheck.IsChecked == true)
            {
                Properties.Settings.Default.log = login;
                Properties.Settings.Default.pass = pass;
                Properties.Settings.Default.Save();
            }

            if (tmp.idRole == 2 || tmp.idRole == 3) isManager = true;



            var serv = new MainWindow();
            serv.Show();
            this.Close();
        }

        private async void createBtn_Click(object sender, RoutedEventArgs e)
        {

            var serv = new RegistrationWindow();
            serv.Show();


        }
            

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            bool? mb1 = new CustomMbox("Login and Password should not be more than 50 characters long. If you still can't log in then try to contact a manager.", MessageType.Info, MessageButtons.Ok).ShowDialog();

        }
    }
}
