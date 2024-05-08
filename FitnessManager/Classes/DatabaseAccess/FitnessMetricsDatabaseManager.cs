using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class FitnessMetricsDatabaseManager
    {
        public async static Task AddFitnessMetrics(FitnessMetrics fm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("INSERT INTO FitnessMetrics (UserId, DailyCalories, DailyCarbs, DailyFats, DailyProteins) values (@UserId, @DailyCalories, @DailyCarbs, @DailyFats, @DailyProteins)", fm);
            }
        }
        public async static Task<FitnessMetrics> GetFitnessMetrics(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QuerySingleAsync<FitnessMetrics>("SELECT * FROM FitnessMetrics WHERE UserId = @UserId", new { UserId = userId });
            }
        }
        public async static Task UpdateFitnessMetrics(FitnessMetrics fm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("UPDATE FitnessMetrics SET DailyCalories = @DailyCalories, DailyCarbs = @DailyCarbs, DailyFats = @DailyFats, DailyProteins = @DailyProteins WHERE UserId = @UserId", fm);
            }
        }
        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
