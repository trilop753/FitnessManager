using FitnessManager.Classes.Models;

namespace FitnessManager.Classes.DatabaseAccess
{
    public static class DatabaseManager
    {

        public async static Task<User> GetLoggedUser(string username)
        {
            User user = await UserDatabaseManager.GetUser(username);

            Task<Account> accountTask = AccountDatabaseManager.GetAccount(user.Id);
            Task<FitnessMetrics> metricsTask = FitnessMetricsDatabaseManager.GetFitnessMetrics(user.Id);
            Task<CurrentMacros> macrosTask = CurrentMacrosDatabaseManager.GetCurrentMacros(user.Id);

            Account account = await accountTask;
            FitnessMetrics metrics = await metricsTask;
            CurrentMacros macros = await macrosTask;

            user.LinkAccount(account);
            account.LinkMetrics(metrics);
            account.LinkMacros(macros);

            return user;
        }

        public async static Task AddRegisteredUserAccount(User user)
        {
            Task accountTask = AccountDatabaseManager.AddAccount(user.Account);
            Task metricsTask = FitnessMetricsDatabaseManager.AddFitnessMetrics(user.Account.Metrics);
            Task macrosTask = CurrentMacrosDatabaseManager.AddCurrentMacros(user.Account.Macros);
            await Task.WhenAll(accountTask, metricsTask, macrosTask);
        }

        public async static Task UpdateAccount(User user)
        {
            await AccountDatabaseManager.UpdateAccount(user.Account);
        }

        public async static Task UpdateMacros(User user)
        {
            await CurrentMacrosDatabaseManager.UpdateCurrentMacros(user.Account.Macros);
        }

        public async static Task UpdateMetrics(User user)
        {
            await FitnessMetricsDatabaseManager.UpdateFitnessMetrics(user.Account.Metrics);
        }
    }
}
