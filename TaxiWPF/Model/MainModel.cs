using System;
using System.ComponentModel;
using TaxiWPF.dto;

namespace TaxiWPF.Model
{
    class MainModel : INotifyPropertyChanged
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

        private string _errMsg;
        public string ErrorMessage
        {
            get
            {
                return _errMsg;
            }
            set
            {
                _errMsg = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        private DrivingModel _carModel = new DrivingModel();
        private UserModel _userModel = new UserModel();
        private OrderModel _orderModel = new OrderModel();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void createOrder(string departure, string destination, string username)
        {
            DrivingDTO driving = tryGetDrivingOrSetErrorMessage();
            if (driving == null)
            {
                return;
            }
            UserDTO user = tryGetUserOrSetErrorMessage(username);
            if (user == null)
            {
                return;
            }
            OrderDTO order = new OrderDTO(driving, user, DateTime.Now, departure, destination);
            _orderModel.saveOrder(order);
        }

        private DrivingDTO tryGetDrivingOrSetErrorMessage()
        {
            try
            {
                return _carModel.getAvailableDrivingToday();

            }
            catch (NullReferenceException e)
            {
                ErrorMessage = e.Message;
                return null;
            }
        }

        private UserDTO tryGetUserOrSetErrorMessage(string username)
        {
            try
            {
                return _userModel.getUserByUsername(username);

            }
            catch (NullReferenceException e)
            {
                ErrorMessage = e.Message;
                return null;
            }
        }

    }
}
