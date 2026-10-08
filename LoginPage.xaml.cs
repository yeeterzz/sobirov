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

namespace auth
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = LoginBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "1234")
            {
                ErrorText.Visibility = Visibility.Collapsed;

                NavigationService.Navigate(new DashboardPage());
            }
            else
            {
                ErrorText.Text = "Неверный логин или пароль";
                ErrorText.Visibility = Visibility.Visible;
            }
        }
    }
}
