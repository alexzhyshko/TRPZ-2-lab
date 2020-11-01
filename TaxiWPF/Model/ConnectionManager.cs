using MySqlConnector;
using System.Data.SqlClient;

namespace TaxiWPF.Model
{
    sealed class ConnectionManager
    {

        private ConnectionManager() { }

        private static string connectionString = "server=localhost;user=root;password=root;database=taxiwpf";

        public static MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
