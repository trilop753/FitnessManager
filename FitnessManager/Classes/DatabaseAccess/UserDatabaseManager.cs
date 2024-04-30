using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class UserDatabaseManager
    {

        public static int GetCount()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int count = cnn.QuerySingle<int>("SELECT COUNT(Id) FROM User");
                return count;
            }
        }

        public static User GetUser(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                User output = cnn.QuerySingle<User>("SELECT * FROM User WHERE UserName = @Username", new { Username = username });
                return output;
            }
        }

        public static bool UserExists(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int count = cnn.QuerySingleOrDefault<int>("SELECT COUNT(Id) FROM User WHERE Username = @Username", new { Username = username });
                return count > 0;
            }
        }

        public static string GetPassword(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string password = cnn.QuerySingle<string>("SELECT Password FROM User WHERE Username = @Username", new { Username = username });
                return password;
            }
        }

        public static void AddUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO User (UserName, Password) VALUES (@UserName, @Password)", user);
            }
        }

        public static List<User> GetAllUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("SELECT * FROM User", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
