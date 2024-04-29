using FitnessManager.Classes.Models;
using System.Text.Json;
namespace FitnessManager.Classes.JsonSerialization
{
    public static class UserSerializer
    {
        public static void AddUser(User user)
        {
            List<User> allUsers = new();
            //string userFilePath = "../../Data/Users";
            string userFilePath = Path.Combine(Environment.CurrentDirectory, "../../../Data/Users");

            if (File.Exists(userFilePath))
            {
                string json = File.ReadAllText(userFilePath);
                List<User>? deserializedUsers = JsonSerializer.Deserialize<List<User>>(json);
                if (deserializedUsers is not null)
                {
                    allUsers = deserializedUsers;
                }
            }
            allUsers.Add(user);

            string updatedJson = JsonSerializer.Serialize(allUsers, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(userFilePath, updatedJson);

        }
    }
}
