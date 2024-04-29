
using FitnessManager.Classes;

namespace FitnessManager
{
    public partial class RegisterForm : Form
    {
        public User RegisteredUser { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           
            if (!checkAllFilled())
            {
                MessageBox.Show("Please fill all information!");
                return;
            }
            float height = float.Parse(heightBox.Text);
            float weight = float.Parse(weightBox.Text);
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

            Account newAccount = new Account(height, weight, isMale, lifestyle, gainMuscles);
            RegisteredUser = new User(usernameBox.Text, passwordBox.Text, newAccount);
            MessageBox.Show("Registering successful, please login.");
            this.Close();
        }

        private bool checkAllFilled()
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text) ||
                string.IsNullOrWhiteSpace(heightBox.Text) ||
                string.IsNullOrWhiteSpace(weightBox.Text) ||
                (!maleButton.Checked && !femaleButton.Checked) ||
                (!sedentaryButton.Checked && !mediumButton.Checked && !activeButton.Checked) ||
                (!muscleButton.Checked && !fatButton.Checked))
            {
                return false;
            }
            return true;
        }
    }
}
