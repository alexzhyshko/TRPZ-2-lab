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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        private RegisterModel _model = new RegisterModel();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            bool result = _model.tryRegister(new dto.UserDTO("username", "password"));
            if (result)
            {
                //proceed to login page
                return;
            }
            errMsg.Text = _model.ErrorMessage;
        }
    }
}
