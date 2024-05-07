using FitnessManager.Classes.Models;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class DatabaseManager
    {

        public static User GetLoggedUser(string username)
        {
            User user = UserDatabaseManager.GetUser(username);
            Account account = AccountDatabaseManager.GetAccount(user.Id);
            user.LinkAccount(account);
            FitnessMetrics metrics = FitnessMetricsDatabaseManager.GetFitnessMetrics(user.Id);
            account.LinkMetrics(metrics);
            CurrentMacros macros = CurrentMacrosDatabaseManager.GetCurrentMacros(user.Id);
            account.LinkMacros(macros);
            return user;
        }

        public static void AddRegisteredUserAccount(User user)
        {
            AccountDatabaseManager.AddAccount(user.Account);
            FitnessMetricsDatabaseManager.AddFitnessMetrics(user.Account.Metrics);
            CurrentMacrosDatabaseManager.AddCurrentMacros(user.Account.Macros);
        }
        public static void UpdateAccount(User user)
        {
            AccountDatabaseManager.UpdateAccount(user.Account);
        }

        public static void UpdateMacros(User user)
        {
            CurrentMacrosDatabaseManager.UpdateCurrentMacros(user.Account.Macros);
        }

        public static void UpdateMetrics(User user)
        {
            FitnessMetricsDatabaseManager.UpdateFitnessMetrics(user.Account.Metrics);
        }
    }
}
