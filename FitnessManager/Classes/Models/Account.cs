using FitnessManager.Classes.Enums;
namespace FitnessManager.Classes.Models
{
    public class Account
    {
        public int UserId { get; private set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public Lifestyle Lifestyle { get; set; }
        public bool GainMuscles { get; set; }

        public FitnessMetrics? Metrics { get; set; }
        public CurrentMacros? Macros { get; set; }


        public Account(int userId, double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            UserId = userId;
            Height = height;
            Weight = weight;
            Age = age;
            Gender = isMale;
            Lifestyle = lifestyle;
            GainMuscles = gainMuscles;
        }

        private Account() { }

        public void SetMetrics()
        {
            Metrics = new FitnessMetrics(UserId, Height, Weight, Age, Gender, Lifestyle, GainMuscles);
        }

        public void SetMacros()
        {
            Macros = new CurrentMacros(UserId);
        }

        public void LinkMetrics(FitnessMetrics metrics)
        {
            Metrics = metrics;
        }

        public void LinkMacros(CurrentMacros macros)
        {
            Macros = macros;
        }
    }
}
