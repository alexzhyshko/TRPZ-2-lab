namespace TaxiWPF.dto
{
    class UserDTO
    {

        public string username;
        public string password;

        public UserDTO(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
