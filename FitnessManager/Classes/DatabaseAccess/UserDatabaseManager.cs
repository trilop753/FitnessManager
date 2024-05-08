using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class UserDatabaseManager
    {

        public async static Task<int> GetCount()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<int>("SELECT COUNT(Id) FROM User");
            }
        }

        public async static Task<User> GetUser(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<User>("SELECT * FROM User WHERE UserName = @Username", new { Username = username });
            }
        }

        public async static Task<bool> UserExists(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleOrDefaultAsync<int>("SELECT COUNT(Id) FROM User WHERE Username = @Username", new { Username = username }) > 0;
            }
        }

        public async static Task<string> GetPassword(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<string>("SELECT Password FROM User WHERE Username = @Username", new { Username = username });
            }
        }

        public async static Task AddUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("INSERT INTO User (UserName, Password) VALUES (@UserName, @Password)", user);
            }
        }

        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
