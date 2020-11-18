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
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {

        public string Username { get; private set; }

        private OrderModel _model;

        public OrdersPage(string username)
        {
            DataContext = _model;
            _model = new OrderModel(username);
            InitializeComponent();

            //TODO debug binding, doesn't work!!
            ordersList.ItemsSource = _model.ordersList;
            Username = username;
        }
    }
}
