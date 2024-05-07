using FitnessManager.Classes.Authentication;
using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Models;
using Microsoft.Win32;
using static Dapper.SqlMapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            register.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X;
            int newY = this.Location.Y;

            register.Location = new Point(newX, newY);
            register.Show();
            this.Hide();
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
            if (!Authenticator.VerifyPassword(password, UserDatabaseManager.GetPassword(username)))
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = DatabaseManager.GetLoggedUser(username);
            MessageBox.Show("Loged in as " + username + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm main = new MainForm(user);
            main.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X;
            int newY = this.Location.Y;

            main.Location = new Point(newX, newY);
            main.FormClosed += (s, args) => this.Close();
            main.Show();
            this.Hide();
        }
    }
}
