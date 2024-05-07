using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class FitnessMetricsDatabaseManager
    {
        public static void AddFitnessMetrics(FitnessMetrics fm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO FitnessMetrics (UserId, DailyCalories, DailyCarbs, DailyFats, DailyProteins) values (@UserId, @DailyCalories, @DailyCarbs, @DailyFats, @DailyProteins)", fm);
            }
        }
        public static FitnessMetrics GetFitnessMetrics(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                FitnessMetrics output = cnn.QuerySingle<FitnessMetrics>("SELECT * FROM FitnessMetrics WHERE UserId = @UserId", new { UserId = userId });
                return output;
            }
        }
        public static void UpdateFitnessMetrics(FitnessMetrics fm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE FitnessMetrics SET DailyCalories = @DailyCalories, DailyCarbs = @DailyCarbs, DailyFats = @DailyFats, DailyProteins = @DailyProteins WHERE UserId = @UserId", fm);
            }
        }
        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
