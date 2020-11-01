using MySqlConnector;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using TaxiWPF.dto;
using TaxiWPF.Service;

namespace TaxiWPF.Model
{
    class RegisterModel
    {

        public string ErrorMessage;
       

        public RegisterModel()
        {

        }

        public bool tryRegister(UserDTO user)
        {
            if (userExists(user))
            {
                ErrorMessage = "User already exists";
                return false;
            }
            createUser(user);
            return true;
        }


        private Boolean userExists(UserDTO user)
        {
            using (MySqlConnection connection = ConnectionManager.getConnection())
            {
                string queryString = "SELECT EXISTS(SELECT id FROM `Users` WHERE username=@username)";
                MySqlCommand command = new MySqlCommand(queryString, connection);

                MySqlParameter usernameParam = new MySqlParameter("@username", SqlDbType.VarChar);
                usernameParam.Value = user.username;
                command.Parameters.Add(usernameParam);
                command.Connection.Open();
                return command.ExecuteScalar().ToString().Equals("1");
            }
        }

        private void createUser(UserDTO user)
        {
            using (MySqlConnection connection = ConnectionManager.getConnection())
            {
                string queryString = "INSERT INTO `Users`(username, password) VALUES(@username, @password)";
                MySqlCommand command = new MySqlCommand(queryString, connection);

                MySqlParameter usernameParam = new MySqlParameter("@username", MySqlDbType.VarChar);
                usernameParam.Value = user.username;
                command.Parameters.Add(usernameParam);

                MySqlParameter passwordParam = new MySqlParameter("@password", MySqlDbType.VarChar);
                passwordParam.Value = HashingService.GetHash(user.password);
                command.Parameters.Add(passwordParam);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
