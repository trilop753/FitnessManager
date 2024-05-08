using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class FoodsDatabaseManager
    {
        public async static Task<IEnumerable<Food>> GetAllFoods()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return await cnn.QueryAsync<Food>("SELECT * FROM Foods");
            }
        }
        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
