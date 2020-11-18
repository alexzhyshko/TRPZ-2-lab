using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {


        private RegisterModel _model = new RegisterModel();

        public RegisterPage()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Password;
            bool result = _model.tryRegister(new dto.UserDTO(username, password));
            if (result)
            {
                goToLoginWindow();
            }
        }

        private void goToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            goToLoginWindow();
        }

        private void goToLoginWindow()
        {
            
        }
    }
}
