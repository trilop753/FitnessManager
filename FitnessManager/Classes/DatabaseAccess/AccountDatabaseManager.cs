using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class AccountDatabaseManager
    {
        public static void AddAccount(Account acc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Account (UserId, Height, Weight, Gender, Lifestyle, GainMuscles) values (@UserId, @Height, @Weight, @IsMale, @Lifestyle, @GainMuscles)", acc);
            }
        }

        public static Account GetAccount(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Account output = cnn.QuerySingle<Account>("SELECT * FROM Account WHERE UserId = @UserId", new { UserId = userId });
                return output;
            }
        }

        public static List<User> GetAllUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
