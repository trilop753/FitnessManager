using FitnessManager.Classes.Authentication;
using FitnessManager.Classes.DatabaseAccess;
using FitnessManager.Classes.Models;

namespace FitnessManager
{
    public partial class StartForm : Form
    {
        private MainForm? Main { get; set; }
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

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (!await UserDatabaseManager.UserExists(username))
            {
                MessageBox.Show("User with this username does not exist, click on Register to create a new account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Authenticator.VerifyPassword(password, await UserDatabaseManager.GetPassword(username)))
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = await DatabaseManager.GetLoggedUser(username);
            MessageBox.Show("Loged in as " + username + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Main = new MainForm(user);
            Main.StartPosition = FormStartPosition.Manual;

            int newX = this.Location.X;
            int newY = this.Location.Y;

            Main.Location = new Point(newX, newY);
            Main.FormClosed += (s, args) => this.Close();
            Main.Logout += (s, args) => ResetAfterLogout();

            Main.Show();
            this.Hide();
        }

        private void ResetAfterLogout()
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
            this.Show();
        }
    }
}
