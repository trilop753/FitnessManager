using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManager
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public MainForm(User user)
        {
            User = user;
            InitializeComponent();
            loggedAsLabel.Text += User.UserName;
            SetMacroMaxes();
            UpdateMacros();
            SetMacroLabels();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseManager.UpdateMacros(User);
            DatabaseManager.UpdateMetrics(User);
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

    }
}
