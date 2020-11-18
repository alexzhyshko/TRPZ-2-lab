using MySqlConnector;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TaxiWPF.dto;

namespace TaxiWPF.Model
{
    class OrderModel : INotifyPropertyChanged
    {

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public ObservableCollection<OrderDTO> ordersList { get; } = new ObservableCollection<OrderDTO>();

        public event PropertyChangedEventHandler PropertyChanged;



        public OrderModel(string username)
        {
            Username = username;
            loadAllUserOrders(Username);
        }

        public OrderModel()
        {

        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void loadAllUserOrders(string username)
        {
            using (MySqlConnection connection = ConnectionManager.getConnection())
            {
                string queryString = "SELECT Orders.id, departure, destination, order_timestamp " +
                "FROM Orders " +
                "JOIN Users ON Orders.user_id = `Users`.id " +
                "WHERE `Users`.username=@username";

                MySqlCommand command = new MySqlCommand(queryString, connection);

                MySqlParameter usernameParam = new MySqlParameter("@username", MySqlDbType.VarChar);
                usernameParam.Value = username;
                command.Parameters.Add(usernameParam);

                command.Connection.Open();
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ordersList.Add(new OrderDTO(dr.GetInt32(0), dr.GetDateTime(3), dr.GetString(1), dr.GetString(2)));
                }
                OnPropertyChanged("ordersList");
            }
        }

        public void saveOrder(OrderDTO order)
        {
            using (MySqlConnection connection = ConnectionManager.getConnection())
            {
                string queryString = "INSERT INTO " +
                    "Orders(driving_id, user_id, departure, destination, order_timestamp) " +
                    "VALUES(@drivingId, @userId, @departure, @destination, NOW())";
                MySqlCommand command = new MySqlCommand(queryString, connection);

                MySqlParameter drivingIdParam = new MySqlParameter("@drivingId", MySqlDbType.Int32);
                drivingIdParam.Value = order.driving.id;
                command.Parameters.Add(drivingIdParam);

                MySqlParameter usernameParam = new MySqlParameter("@userId", MySqlDbType.Int32);
                usernameParam.Value = order.user.id;
                command.Parameters.Add(usernameParam);

                MySqlParameter departureParam = new MySqlParameter("@departure", MySqlDbType.VarChar);
                departureParam.Value = order.departure;
                command.Parameters.Add(departureParam);

                MySqlParameter destinationParam = new MySqlParameter("@destination", MySqlDbType.VarChar);
                destinationParam.Value = order.destination;
                command.Parameters.Add(destinationParam);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
