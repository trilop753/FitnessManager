using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.JsonSerialization;
using FitnessManager.Classes.Models;
using FitnessManager.Forms;

namespace FitnessManager
{
    public partial class MainForm : Form
    {
        public User User { get; set; }

        public event EventHandler? Logout;

        public event EventHandler? MacrosUpdated;

        public MainForm(User user)
        {
            User = user;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            SetMacroMaxes();
            UpdateMacros();
            SetMacroLabels();
        }

        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await DatabaseManager.UpdateMacros(User);
        }

        private void addMacrosButton_Click(object sender, EventArgs e)
        {
            AddForm adder = new(this);
            adder.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X + this.Width - 10;
            int newY = this.Location.Y;

            adder.Location = new Point(newX, newY);
            adder.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new(this);
            settings.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X;
            int newY = this.Location.Y + this.Height - 3;

            settings.Location = new Point(newX, newY);
            settings.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new(this);
            settings.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X;
            int newY = this.Location.Y + this.Height - 3;

            settings.Location = new Point(newX, newY);
            settings.Show();
        }

        private void activityButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset current macronutriens?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                User.Account.Macros.Reset();
            }
            UpdateMacros();
        }

        public void UpdateMacros()
        {
            NormalizeMacros();
            SetMacroMaxes();
            caloriesProgressBar.Value = User.Account.Macros.Calories;
            carbsProgressBar.Value = User.Account.Macros.Carbs;
            fatsProgressBar.Value = User.Account.Macros.Fats;
            proteinsProgressBar.Value = User.Account.Macros.Proteins;
            SetMacroLabels();
            MacrosUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void SetMacroMaxes()
        {
            caloriesProgressBar.Maximum = User.Account.Metrics.DailyCalories;
            carbsProgressBar.Maximum = User.Account.Metrics.DailyCarbs;
            fatsProgressBar.Maximum = User.Account.Metrics.DailyFats;
            proteinsProgressBar.Maximum = User.Account.Metrics.DailyProteins;
        }

        private void SetMacroLabels()
        {
            string calories = caloriesProgressBar.Value.ToString();
            string space = new string(' ', 4 - calories.Length);
            currentCaloriesLabel.Text = space + calories;

            string carbs = carbsProgressBar.Value.ToString();
            space = new string(' ', 5 - carbs.Length);
            currentCarbsLabel.Text = space + carbs;

            string fats = fatsProgressBar.Value.ToString();
            space = new string(' ', 5 - fats.Length);
            currentFatsLabel.Text = space + fats;

            string prot = proteinsProgressBar.Value.ToString();
            space = new string(' ', 5 - prot.Length);
            currentProteinsLabel.Text = space + prot;
        }

        private void NormalizeMacros()
        {
            CurrentMacros current = User.Account.Macros;
            FitnessMetrics total = User.Account.Metrics;

            if (current.Calories >= total.DailyCalories)
            {
                current.Calories = total.DailyCalories;
            }
            if (current.Calories < 0)
            {
                current.Calories = 0;
            }
            if (current.Carbs >= total.DailyCarbs)
            {
                current.Carbs = total.DailyCarbs;
            }
            if (current.Carbs < 0)
            {
                current.Carbs = 0;
            }
            if (current.Fats >= total.DailyFats)
            {
                current.Fats = total.DailyFats;
            }
            if (current.Fats < 0)
            {
                current.Fats = 0;
            }
            if (current.Proteins >= total.DailyProteins)
            {
                current.Proteins = total.DailyProteins;
            }
            if (current.Proteins < 0)
            {
                current.Proteins = 0;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Buttons: " + Environment.NewLine +
                ">Press Add to add macronutrients." + Environment.NewLine +
                ">Press Reset to reset the values to 0." + Environment.NewLine +
                ">Press Logout to logout and open login screen." + Environment.NewLine +
                "Menu strip: " + Environment.NewLine +
                ">Press Settings to open settings." + Environment.NewLine +
                ">Press Profile to see all information about the user." + Environment.NewLine +
                "In settings you can update your account characteristics and manually set maximum values of macros." + Environment.NewLine +
                ">Press Export to export current tracked values to Json.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, EventArgs.Empty);
            await DatabaseManager.UpdateMacros(User);
            this.Hide();
            MessageBox.Show("Successfully logged out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manager for tracking calories and other " +
                "macronutrients for achieving your fitness goals." + Environment.NewLine +
                "© 2024 - 2024 | Maroš Pavlík 536589, FIMUNI, Brno, Czechia. All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new(this);
            profile.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X - profile.Width + 10;
            int newY = this.Location.Y;

            profile.Location = new Point(newX, newY);
            profile.Show();
        }

        private async void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please confirm to export to Json.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
            ExportClass export = new(User.UserName, User.Account, User.Account.Metrics, User.Account.Macros);
            await export.Serialize();
            MessageBox.Show("Successfully exported to " + Path.GetFullPath("Export.json") + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
