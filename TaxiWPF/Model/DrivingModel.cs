using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiWPF.dto;

namespace TaxiWPF.Model
{
    class DrivingModel
    {

        public DrivingDTO getAvailableDrivingByDate(DateTime date)
        {
            using (MySqlConnection connection = ConnectionManager.getConnection())
            {
                string queryString = "SELECT Driving.id, Cars.id, Cars.plate, Drivers.id, Drivers.name " +
                    "FROM Driving " +
                    "JOIN Cars ON Cars.id = Driving.car_id " +
                    "JOIN Drivers ON Drivers.id = Driving.driver_id " +
                    "WHERE day_of_driving = CURDATE() " +
                    "LIMIT 1";
                MySqlCommand command = new MySqlCommand(queryString, connection);

                command.Connection.Open();
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return new DrivingDTO(dr.GetInt32(0), new DriverDTO(dr.GetInt32(3), dr.GetString(4)), new CarDTO(dr.GetInt32(1), dr.GetString(2)));
                }
                throw new NullReferenceException("Could not find a car by date "+date.ToString());
            }
        } 

        public DrivingDTO getAvailableDrivingToday()
        {
            return getAvailableDrivingByDate(DateTime.Today);
        }

    }
}
