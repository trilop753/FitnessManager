using FitnessManager.Classes.Authentication;
using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Enums;
using FitnessManager.Classes.Models;

namespace FitnessManager
{
    public partial class RegisterForm : Form
    {
        private StartForm Starter { get; set; }
        public RegisterForm(StartForm starter)
        {
            InitializeComponent();
            Starter = starter;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (!await Register())
            {
                return;
            }
            MessageBox.Show("Registering successful, please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Starter.Show();
            this.Close();
        }

        private bool CheckAllFilled()
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text) ||
                string.IsNullOrWhiteSpace(heightBox.Text) ||
                string.IsNullOrWhiteSpace(weightBox.Text) ||
                string.IsNullOrWhiteSpace(ageBox.Text) ||
                (!maleButton.Checked && !femaleButton.Checked) ||
                (!sedentaryButton.Checked && !mediumButton.Checked && !activeButton.Checked) ||
                (!muscleButton.Checked && !fatButton.Checked))
            {
                return false;
            }
            return true;
        }

        private async Task<bool> Register()
        {
            if (!CheckAllFilled())
            {
                MessageBox.Show("Please fill all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double height, weight;
            int age;
            if (!double.TryParse(heightBox.Text, out height) || !double.TryParse(weightBox.Text, out weight) || !int.TryParse(ageBox.Text, out age))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for both height, weight and age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool isMale = maleButton.Checked ? true : false;

            Lifestyle lifestyle;
            if (sedentaryButton.Checked)
            {
                lifestyle = Lifestyle.SEDENTARY;
            }
            else if (mediumButton.Checked)
            {
                lifestyle = Lifestyle.MEDIUM;
            }
            else
            {
                lifestyle = Lifestyle.ACTIVE;
            }
            bool gainMuscles = muscleButton.Checked ? true : false;
            if ((await UserDatabaseManager.GetCount() != 0) && await UserDatabaseManager.UserExists(usernameBox.Text))
            {
                MessageBox.Show("User with this username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string passwordHashed = Authenticator.HashPassword(passwordBox.Text);

            User registeredUser = new User(usernameBox.Text, passwordHashed);
            await UserDatabaseManager.AddUser(registeredUser);

            registeredUser = await UserDatabaseManager.GetUser(registeredUser.UserName);

            Account newAccount = new Account(registeredUser.Id, height, weight, age, isMale, lifestyle, gainMuscles);

            newAccount.SetMetrics();
            newAccount.SetMacros();
            registeredUser.LinkAccount(newAccount);

            await DatabaseManager.AddRegisteredUserAccount(registeredUser);
            return true;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Starter.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Starter.Show();
            this.Close();
        }
    }
}
