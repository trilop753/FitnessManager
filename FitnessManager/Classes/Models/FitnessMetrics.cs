using FitnessManager.Classes.Constants;
using FitnessManager.Classes.Enums;

namespace FitnessManager.Classes.Models
{
    public class FitnessMetrics
    {
        public int UserId { get; set; }
        public int DailyCalories { get; private set; }
        public int DailyCarbs { get; private set; }
        public int DailyFats { get; private set; }
        public int DailyProteins { get; private set; }
        public double BMI { get; private set; }

        public FitnessMetrics(int userId, double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            UserId = userId;
            BMI = CalculateBMI(height, weight);
            CalculateDailyCalories(height, weight, age, isMale, lifestyle, gainMuscles);
            CalculateMacros(weight, lifestyle, gainMuscles);
        }

        private FitnessMetrics() { }

        public void RecalculateMetrics(double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            BMI = CalculateBMI(height, weight);
            CalculateDailyCalories(height, weight, age, isMale, lifestyle, gainMuscles);
            CalculateMacros(weight, lifestyle, gainMuscles);
        }

        public void SetManualMetrics(int calories, int carbs, int fats, int proteins)
        {
            DailyCalories = calories;
            DailyCarbs = carbs;
            DailyFats = fats;
            DailyProteins = proteins;
        }

        private double CalculateBMI(double height, double weight)
        {
            double bmi = weight / (double) Math.Pow(height / 100, 2);
            return bmi;
        }

        private void CalculateDailyCalories(double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            double bmrConstant, weightMultiplier, heightMultiplier, ageMultiplier;
            if (isMale)
            {
                bmrConstant = CalorieConstants.ManBmrConstant;
                weightMultiplier = CalorieConstants.ManBmrWeightMultiplier;
                heightMultiplier = CalorieConstants.ManBmrHeightMultiplier;
                ageMultiplier = CalorieConstants.ManBmrAgeMultiplier;
            }
            else
            {
                bmrConstant = CalorieConstants.WomanBmrConstant;
                weightMultiplier = CalorieConstants.WomanBmrWeightMultiplier;
                heightMultiplier = CalorieConstants.WomanBmrHeightMultiplier;
                ageMultiplier = CalorieConstants.WomanBmrAgeMultiplier;
            }
            double bmr = bmrConstant + weightMultiplier * weight
                                     + heightMultiplier * height
                                     - ageMultiplier * age;
            double amr;
            switch (lifestyle)
            {
                case Lifestyle.SEDENTARY:
                {
                    amr = bmr * CalorieConstants.SedentaryAmrMultiplier;
                    break;
                }
                case Lifestyle.MEDIUM:
                {
                    amr = bmr * CalorieConstants.MediumAmrMultiplier;
                    break;
                }
                default:
                {
                    amr = bmr * CalorieConstants.ActiveAmrMultiplier;
                    break;
                }

            }

            if (gainMuscles)
            {
                amr += CalorieConstants.CalorieSurplus;
            }
            else
            {
                amr -= CalorieConstants.CalorieSurplus;
            }

            DailyCalories = (int) amr;
        }

        private void CalculateMacros(double weight, Lifestyle lifestyle, bool gainMuscles)
        {
            DailyCarbs = (int) ((DailyCalories * (gainMuscles ? CalorieConstants.DailyBulkCarbsPercentage :
                CalorieConstants.DailyCutCarbsPercentage)) / CalorieConstants.CarbsDivisor);

            DailyFats = (int) ((DailyCalories * CalorieConstants.DailyFatsPercentage) / CalorieConstants.FatsDivisor);

            switch (lifestyle)
            {
                case Lifestyle.SEDENTARY:
                    DailyProteins = (int) (weight * CalorieConstants.SedentaryProteinMultiplier);
                    break;
                case Lifestyle.MEDIUM:
                    DailyProteins = (int)(weight * CalorieConstants.MediumProteinMultiplier);
                    break;
                default:
                    DailyProteins = (int)(weight * CalorieConstants.ActiveProteinMultiplier);
                    break;
            }


        }
    }
}
