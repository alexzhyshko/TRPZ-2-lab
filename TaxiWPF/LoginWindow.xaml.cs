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
using TaxiWPF.Model;

namespace TaxiWPF
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private LoginModel _model = new LoginModel();

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Password;
            if (_model.tryLogin(new dto.UserDTO(username, password)))
            {
                goToMainWindow(username);
            }
        }

        private void goToMainWindow(string username)
        {
            new MainWindow(username).Show();
            Close();
        }

        private void goToRegisterButton_Click(object sender, RoutedEventArgs e)
        {
            goToRegisterWindow();
        }

        private void goToRegisterWindow()
        {
            new RegisterWindow().Show();
            Close();
        }
    }
}
