
namespace FitnessManager
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Account? Account { get; private set; }


        private static int id_generator = 1;
    
        public User(string userName, string password, Account? account)
        {
            Id = id_generator++;
            UserName = userName;
            Password = password;
            Account = account;
        }
    }
}
