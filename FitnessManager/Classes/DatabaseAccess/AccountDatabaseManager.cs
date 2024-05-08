using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class AccountDatabaseManager
    {
        public async static Task AddAccount(Account acc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("insert into Account (UserId, Height, Weight, Age, Gender, Lifestyle, GainMuscles) values (@UserId, @Height, @Weight, @Age, @Gender, @Lifestyle, @GainMuscles)", acc);
            }
        }

        public async static Task<Account> GetAccount(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<Account>("SELECT * FROM Account WHERE UserId = @UserId", new { UserId = userId });
            }
        }

        public async static Task UpdateAccount(Account acc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("UPDATE Account SET Height = @Height, Weight = @Weight, Age = @Age, Gender = @Gender, Lifestyle = @Lifestyle, GainMuscles = @GainMuscles WHERE UserId = @UserId", acc);
            }
        }

        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
