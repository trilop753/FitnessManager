using FitnessManager.Classes.Models;
using System.Text;

namespace FitnessManager
{
    public partial class AddForm : Form
    {
        private MainForm Main { get; set; }
        public AddForm(MainForm main)
        {
            Main = main;
            InitializeComponent();
        }

        private void addMacrosButton_Click(object sender, EventArgs e)
        {
            int calories = 0, carbs = 0, fats = 0, proteins = 0;
            ;
            if ((!int.TryParse(addCaloriesBox.Text, out calories) && !(addCaloriesBox.Text.Length == 0)) ||
                (!int.TryParse(addCarbsBox.Text, out carbs) && !(addCarbsBox.Text.Length == 0)) ||
                (!int.TryParse(addFatsBox.Text, out fats) && !(addFatsBox.Text.Length == 0)) ||
                (!int.TryParse(addProteinsBox.Text, out proteins) && !(addProteinsBox.Text.Length == 0)))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Main.User.Account.Macros.AddMacros(calories, carbs, fats, proteins);
            CheckGoalAchieved();
            Main.UpdateMacros();
            this.Close();
        }

        private void CheckGoalAchieved()
        {
            FitnessMetrics total = Main.User.Account.Metrics;
            CurrentMacros current = Main.User.Account.Macros;
            StringBuilder completed = new StringBuilder();
            bool added = false;


            if (current.Calories >= total.DailyCalories)
            {
                completed.Append("calories");
                added = true;
            }
            if (current.Carbs >= total.DailyCarbs)
            {
                if (added)
                {
                    completed.Append(", ");
                }
                added = true;
                completed.Append("carbohydrates");
            }
            if (current.Fats >= total.DailyFats)
            {
                if (added)
                {
                    completed.Append(", ");
                }
                added = true;
                completed.Append("fats");
            }
            if (current.Proteins >= total.DailyProteins)
            {
                if (added)
                {
                    completed.Append(", ");
                }
                added = true;
                completed.Append("proteins");
            }
            MessageBox.Show("You have completed your daily " + completed.ToString() + " goal.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
