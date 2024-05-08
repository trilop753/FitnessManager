using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Models;
using System.Text;
using System.Windows.Forms;

namespace FitnessManager
{
    public partial class AddForm : Form
    {
        private MainForm Main { get; set; }
        private IEnumerable<Food> OriginalFoodsList { get; set; }
        private Food? SelectedFood { get; set; }
        public AddForm(MainForm main)
        {
            Main = main;
            Main.FormClosed += (s, args) => this.Close();
            Main.Logout += (s, args) => this.Close();
            InitializeComponent();
            SetOriginalFoodsList();
            ShowFoodList(OriginalFoodsList);
        }
        private async void SetOriginalFoodsList()
        {
            OriginalFoodsList = await FoodsDatabaseManager.GetAllFoods();
        }

        private void ShowFoodList(IEnumerable<Food> foodsList)
        {
            foods.DataSource = foodsList;
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
            AddFoodMacros();
            CheckGoalAchieved();
            Main.UpdateMacros();
            this.Close();
        }

        private void AddFoodMacros()
        {
            if (SelectedFood is null)
            {
                return;
            }
            int grams = 0;
            if (gramsBox.Text.Length == 0)
            {
                return;
            }
            if (!int.TryParse(gramsBox.Text, out grams))
            {
                MessageBox.Show("Invalid input. Please enter valid number of grams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Main.User.Account.Macros.AddMacros(SelectedFood, grams);

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
            if (added)
            {
                MessageBox.Show("You have completed your daily " + completed.ToString() + " goal.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.ToLower();
            List<Food> searchedFoods = new List<Food>();


            foreach (Food item in OriginalFoodsList)
            {
                if (item.Name.ToLower().Contains(searchTerm.ToLower()))
                {
                    searchedFoods.Add(item);
                }
            }
            foods.DataSource = searchedFoods;
        }

        private void foods_SelectedChanged(object sender, EventArgs e)
        {
            if (foods.SelectedIndex != -1)
            {
                SelectedFood = (Food?) foods.SelectedValue;
            }
        }
    }
}
