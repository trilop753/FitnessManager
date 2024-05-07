using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Enums;
using FitnessManager.Classes.Models;

namespace FitnessManager
{
    public partial class SettingsForm : Form
    {
        private MainForm Main { get; set; }
        private int[] macrosSettings = new int[4];
        public SettingsForm(MainForm main)
        {
            Main = main;
            InitializeComponent();
            InitializeOldSettings();
        }
        private void accountUpdateButton_Click(object sender, EventArgs e)
        {
            double height = Main.User.Account.Height;
            double weight = Main.User.Account.Weight;
            int age = Main.User.Account.Age;

            if ((!double.TryParse(heightBox.Text, out height) && !(heightBox.Text.Length == 0)) ||
                (!double.TryParse(weightBox.Text, out weight) && !(weightBox.Text.Length == 0)) ||
                (!int.TryParse(ageBox.Text, out age) && !(ageBox.Text.Length == 0)))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Main.User.Account.Height = height == 0 ? Main.User.Account.Height : height;
            Main.User.Account.Weight = weight == 0 ? Main.User.Account.Weight : weight;
            Main.User.Account.Age = age == 0 ? Main.User.Account.Age : age;

            Main.User.Account.Gender = maleButton.Checked ? true : false;
            if (sedentaryButton.Checked)
            {
                Main.User.Account.Lifestyle = Lifestyle.SEDENTARY;
            }
            else if (mediumButton.Checked)
            {
                Main.User.Account.Lifestyle = Lifestyle.MEDIUM;
            }
            else
            {
                Main.User.Account.Lifestyle = Lifestyle.ACTIVE;
            }
            Main.User.Account.GainMuscles = muscleButton.Checked ? true : false;
            DatabaseManager.UpdateAccount(Main.User);
            Account account = Main.User.Account;
            account.Metrics.RecalculateMetrics(account.Height, account.Weight, account.Age, account.Gender, account.Lifestyle, account.GainMuscles);
            DatabaseManager.UpdateMetrics(Main.User);
            Main.UpdateMacros();
            MessageBox.Show("Settings saved successfully. Recalculating recommended macronutrients.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InitializeOldSettings()
        {
            heightBox.PlaceholderText = Main.User.Account.Height.ToString();
            weightBox.PlaceholderText = Main.User.Account.Weight.ToString();
            ageBox.PlaceholderText = Main.User.Account.Age.ToString();
            if (Main.User.Account.Gender)
            {
                maleButton.Checked = true;
            }
            else
            {
                femaleButton.Checked = true;
            }
            switch (Main.User.Account.Lifestyle)
            {
                case Lifestyle.SEDENTARY:
                    sedentaryButton.Checked = true;
                    break;
                case Lifestyle.MEDIUM:
                    mediumButton.Checked = true;
                    break;
                default:
                    activeButton.Checked = true;
                    break;
            }

            if (Main.User.Account.GainMuscles)
            {
                muscleButton.Checked = true;
            }
            else
            {
                fatButton.Checked = true;
            }

            macrosSettings[0] = Main.User.Account.Metrics.DailyCalories;
            macrosSettings[1] = Main.User.Account.Metrics.DailyCarbs;
            macrosSettings[2] = Main.User.Account.Metrics.DailyFats;
            macrosSettings[3] = Main.User.Account.Metrics.DailyProteins;
            updateMacroLabels();
        }

        private void updateMacroLabels()
        {
            caloriesLabel.Text = macrosSettings[0].ToString();
            carbsLabel.Text = macrosSettings[1].ToString();
            fatsLabel.Text = macrosSettings[2].ToString();
            proteinsLabel.Text = macrosSettings[3].ToString();
        }

        private void caloriesMinusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[0] -= 50;
            updateMacroLabels();
        }

        private void carbsMinusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[1] -= 10;
            updateMacroLabels();
        }

        private void fatsMinusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[2] -= 10;
            updateMacroLabels();
        }

        private void proteinsMinusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[3] -= 10;
            updateMacroLabels();
        }

        private void caloriesPlusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[0] += 50;
            updateMacroLabels();
        }

        private void carbsPlusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[1] += 10;
            updateMacroLabels();
        }

        private void fatsPlusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[2] += 10;
            updateMacroLabels();
        }

        private void proteinsPlusButton_Click(object sender, EventArgs e)
        {
            macrosSettings[3] += 10;
            updateMacroLabels();
        }

        private void macrosUpdateButton_Click(object sender, EventArgs e)
        {
            Main.User.Account.Metrics.SetManualMetrics(macrosSettings[0], macrosSettings[1], macrosSettings[2], macrosSettings[3]);
            DatabaseManager.UpdateMetrics(Main.User);
            Main.UpdateMacros();
            MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
