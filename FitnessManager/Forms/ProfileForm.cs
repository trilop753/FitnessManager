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

namespace FitnessManager.Forms
{
    public partial class ProfileForm : Form
    {
        private MainForm Main { get; set; }
        public ProfileForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
            Main.MacrosUpdated += (s, args) => SetProfile();
            Main.FormClosed += (s, args) => this.Close();
            Main.Logout += (s, args) => this.Close();
            SetProfile();
        }

        private void SetProfile()
        {
            usernameLabel.Text = Main.User.UserName;
            ageLabel.Text = Main.User.Account.Age.ToString();
            heightLabel.Text = Main.User.Account.Height.ToString();
            weightLabel.Text = Main.User.Account.Weight.ToString();
            genderLabel.Text = Main.User.Account.Gender ? "Male" : "Female";
            lifestyleLabel.Text = Main.User.Account.Lifestyle.ToString().ToLower();
            goalLabel.Text = Main.User.Account.GainMuscles ? "Gain Muscles" : "Lose weight";
            bmiLabel.Text = Main.User.Account.GetBMI();

            caloriesLabel.Text = Main.User.Account.Macros.Calories.ToString() + "/" + Main.User.Account.Metrics.DailyCalories;
            carbsLabel.Text = Main.User.Account.Macros.Carbs.ToString() + "/" + Main.User.Account.Metrics.DailyCarbs;
            fatsLabel.Text = Main.User.Account.Macros.Fats.ToString() + "/" + Main.User.Account.Metrics.DailyFats;
            proteinsLabel.Text = Main.User.Account.Macros.Proteins.ToString() + "/" + Main.User.Account.Metrics.DailyProteins;
        }




    }
}
