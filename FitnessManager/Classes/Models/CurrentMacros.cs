namespace FitnessManager.Classes.Models
{
    public class CurrentMacros
    {
        public int Calories { get; private set; }
        public int Carbohydrates { get; private set; }
        public int Fats { get; private set; }
        public int Proteins { get; private set; }


        public CurrentMacros()
        {
            Calories = 0;
            Carbohydrates = 0;
            Fats = 0;
            Proteins = 0;
        }

        private CurrentMacros(int calories, int carbohydrates, int fats, int proteins)
        {
            Calories = calories;
            Carbohydrates = carbohydrates;
            Fats = fats;
            Proteins = proteins;
        }

        public void AddMacros(int calories, int carbs, int fats, int proteins)
        {
            Calories += calories;
            Carbohydrates += carbs;
            Fats += fats;
            Proteins += proteins;
        }

        //public void AddMacros(Food food, float weight)
        //{

        //}

        //public void AddMacros(Activity activity, float time)
        //{

        //}


    }
}
