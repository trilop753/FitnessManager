using FitnessManager.Classes.Enums;
namespace FitnessManager.Classes.Models
{
    public class Account
    {
        public int UserId { get; private set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public Lifestyle Lifestyle { get; set; }
        public bool GainMuscles { get; set; }

        public FitnessMetrics Metrics { get; set; }


        public Account(int userId, double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            UserId = userId;
            Height = height;
            Weight = weight;
            Age = age;
            IsMale = isMale;
            Lifestyle = lifestyle;
            GainMuscles = gainMuscles;
        }

        private Account() { }

        public void SetMetrics()
        {
            Metrics = new FitnessMetrics(Height, Weight, Age, IsMale, Lifestyle, GainMuscles);
        }
    }
}
