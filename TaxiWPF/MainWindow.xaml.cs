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
using TaxiWPF.Model;

namespace TaxiWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainModel _model = new MainModel();

        public string Username { get; private set; }

        public MainWindow(string username)
        {
            InitializeComponent();
            DataContext = _model;
            _model.Username = username;
            Username = username;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string departure = departureText.Text;
            string destination = destinationText.Text;
            _model.createOrder(departure, destination, Username);
        }

        private void goToOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            new OrdersWindow(Username).Show();
            Close();
        }
    }
}
