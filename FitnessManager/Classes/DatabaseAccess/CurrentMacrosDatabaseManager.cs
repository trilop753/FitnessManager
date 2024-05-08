using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class CurrentMacrosDatabaseManager
    {
        public async static Task AddCurrentMacros(CurrentMacros cm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("INSERT INTO CurrentMacros (UserId, Calories, Carbs, Fats, Proteins) values (@UserId, @Calories, @Carbs, @Fats, @Proteins)", cm);
            }
        }
        public async static Task<CurrentMacros> GetCurrentMacros(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<CurrentMacros>("SELECT * FROM CurrentMacros WHERE UserId = @UserId", new { UserId = userId });
            }
        }
        public async static Task UpdateCurrentMacros(CurrentMacros cm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("UPDATE CurrentMacros SET Calories = @Calories, Carbs = @Carbs, Fats = @Fats, Proteins = @Proteins WHERE UserId = @UserId", cm);
            }
        }
        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
