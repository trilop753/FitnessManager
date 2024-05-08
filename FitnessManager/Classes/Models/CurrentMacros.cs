namespace FitnessManager.Classes.Models
{
    public class CurrentMacros
    {
        public int UserId { get; set; }
        public int Calories { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
        public int Proteins { get; set; }


        public CurrentMacros(int userId)
        {
            Calories = 0;
            Carbs = 0;
            Fats = 0;
            Proteins = 0;
            UserId = userId;
        }

        private CurrentMacros() { }

        public void AddMacros(int calories, int carbs, int fats, int proteins)
        {
            Calories += calories;
            Carbs += carbs;
            Fats += fats;
            Proteins += proteins;
        }

        public void AddMacros(Food food, int grams)
        {
            double per100g = (double)grams / 100;
            this.AddMacros((int)(food.Calories * per100g), (int)(food.Carbs * per100g), (int)(food.Fats * per100g), (int)(food.Proteins * per100g));
        }

        //public void AddMacros(Activity activity, float time)
        //{

        //}

        public void Reset()
        {
            Calories = 0;
            Carbs = 0;
            Fats = 0;
            Proteins = 0;
        }
    }
}
