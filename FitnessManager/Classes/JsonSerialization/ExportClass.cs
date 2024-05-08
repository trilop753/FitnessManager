using FitnessManager.Classes.Enums;
using FitnessManager.Classes.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FitnessManager.Classes.JsonSerialization
{
    [JsonConverter(typeof(ExportJsonConverter))]
    public class ExportClass
    {
        public string Username { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public int Age { get; private set; }
        public bool Gender { get; private set; }
        public Lifestyle Lifestyle { get; private set; }
        public bool GainMuscles { get; private set; }
        public string BMI { get; private set; }
        public FitnessMetrics Metrics { get; private set; }
        public CurrentMacros Macros { get; private set; }


        public ExportClass(string username, Account account, FitnessMetrics metrics, CurrentMacros macros)
        {
            Username = username;
            Height = account.Height;
            Weight = account.Weight;
            Age = account.Age;
            Gender = account.Gender;
            Lifestyle = account.Lifestyle;
            GainMuscles = account.GainMuscles;
            BMI = account.GetBMI();
            Metrics = metrics;
            Macros = macros;
        }

        public async Task Serialize()
        {
            await Task.Run(() =>
            {
                string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("Export.json", json);
            });
        }


    }
}
