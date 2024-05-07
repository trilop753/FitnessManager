using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class CurrentMacrosDatabaseManager
    {
        public static void AddCurrentMacros(CurrentMacros cm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO CurrentMacros (UserId, Calories, Carbs, Fats, Proteins) values (@UserId, @Calories, @Carbs, @Fats, @Proteins)", cm);
            }
        }
        public static CurrentMacros GetCurrentMacros(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                CurrentMacros output = cnn.QuerySingle<CurrentMacros>("SELECT * FROM CurrentMacros WHERE UserId = @UserId", new { UserId = userId });
                return output;
            }
        }
        public static void UpdateCurrentMacros(CurrentMacros cm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE CurrentMacros SET Calories = @Calories, Carbs = @Carbs, Fats = @Fats, Proteins = @Proteins WHERE UserId = @UserId", cm);
            }
        }
        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
