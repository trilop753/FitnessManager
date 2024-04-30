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

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!Register())
            {
                return;
            }
            MessageBox.Show("Registering successful, please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Starter.Show();
            this.Close();
        }

        private bool checkAllFilled()
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

        private bool Register()
        {
            if (!checkAllFilled())
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
            if (UserDatabaseManager.GetCount() != 0 && UserDatabaseManager.UserExists(usernameBox.Text))
            {
                MessageBox.Show("User with this username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            User RegisteredUser = new User(usernameBox.Text, passwordBox.Text);
            UserDatabaseManager.AddUser(RegisteredUser);
            RegisteredUser = UserDatabaseManager.GetUser(RegisteredUser.UserName);


            Account newAccount = new Account(RegisteredUser.Id, height, weight, age, isMale, lifestyle, gainMuscles);
            AccountDatabaseManager.AddAccount(newAccount);
            return true;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Starter.Close();
        }
    }
}
