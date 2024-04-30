using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Models;

namespace FitnessManager
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            this.Hide();
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (!UserDatabaseManager.UserExists(username))
            {
                MessageBox.Show("User with this username does not exist, click on Register to create a new account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Equals(UserDatabaseManager.GetPassword(username)))
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = UserDatabaseManager.GetUser(username);
            user.LinkAccount(AccountDatabaseManager.GetAccount(user.Id));
            user.Account.SetMetrics();
            FitnessMetrics met = user.Account.Metrics;
            MessageBox.Show("Loged in as " + username + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
