
namespace FitnessManager.Classes
{
    public class Account
    {
        public int Id { get; private set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public bool IsMale { get; set; }
        public Lifestyle Lifestyle { get; set; }
        public bool GainMuscles { get; set; }

        public Account(float height, float weight, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            Height = height;
            Weight = weight;
            IsMale = isMale;
            Lifestyle = lifestyle;
            GainMuscles = gainMuscles;
        }
    }
}
