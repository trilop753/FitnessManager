﻿using Dapper;
using FitnessManager.Classes.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class AccountDatabaseManager
    {
        public async static void AddAccount(Account acc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("insert into Account (UserId, Height, Weight, Age, Gender, Lifestyle, GainMuscles) values (@UserId, @Height, @Weight, @Age, @Gender, @Lifestyle, @GainMuscles)", acc);
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

        public static void UpdateAccount(Account acc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Account SET Height = @Height, Weight = @Weight, Age = @Age, Gender = @Gender, Lifestyle = @Lifestyle, GainMuscles = @GainMuscles WHERE UserId = @UserId", acc);
            }
        }

        private static string LoadConnectionString(string cs = "Default")
        {
            return ConfigurationManager.ConnectionStrings[cs].ConnectionString;
        }
    }
}
