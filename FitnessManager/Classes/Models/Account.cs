using FitnessManager.Classes.Enums;
namespace FitnessManager.Classes.Models
{
    public class Account
    {
        public int UserId { get; private set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public bool IsMale { get; set; }
        public Lifestyle Lifestyle { get; set; }
        public bool GainMuscles { get; set; }


        public Account(int userId, float height, float weight, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            UserId = userId;
            Height = height;
            Weight = weight;
            IsMale = isMale;
            Lifestyle = lifestyle;
            GainMuscles = gainMuscles;
        }

        private Account() { }
    }
}
