using System.Text.Json.Serialization;

namespace FitnessManager.Classes.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        [JsonIgnore]
        public Account? Account { get; private set; }



        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        private User() { }
    }
}
