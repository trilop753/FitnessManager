using FitnessManager.Classes.Constants;
using FitnessManager.Classes.Enums;

namespace FitnessManager.Classes.Models
{
    public class FitnessMetrics
    {
        public int DailyCalories { get; private set; }
        public int DailyCarbohydrates { get; private set; }
        public int DailyFats { get; private set; }
        public int DailyProteins { get; private set; }
        public double BMI { get; private set; }

        public FitnessMetrics(double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
        {
            BMI = CalculateBMI(height, weight);
            DailyCalories = CalculateDailyCalories(height, weight, age, isMale, lifestyle, gainMuscles);
        }

        private double CalculateBMI(double height, double weight)
        {
            double bmi = weight / (double) Math.Pow(height / 100, 2);
            return bmi;
        }

        private int CalculateDailyCalories(double height, double weight, int age, bool isMale, Lifestyle lifestyle, bool gainMuscles)
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

            return (int) amr;
        }

        //private int CalculateMacros()
    }
}
