namespace FitnessManager
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLabel = new Label();
            usernameLabel = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            registerLabel = new LinkLabel();
            loginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F);
            loginLabel.Location = new Point(102, 51);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(69, 28);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "LOGIN";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(36, 85);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(102, 82);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(102, 111);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(39, 114);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 40);
            label1.TabIndex = 5;
            label1.Text = "Fitness Manager";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(usernameLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 188);
            panel1.TabIndex = 6;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new Point(61, 148);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(49, 15);
            registerLabel.TabIndex = 7;
            registerLabel.TabStop = true;
            registerLabel.Text = "Register";
            registerLabel.LinkClicked += registerLabel_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(188, 140);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(57, 30);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(304, 211);
            Controls.Add(panel1);
            Name = "StartForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label loginLabel;
        private Label usernameLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private Label label1;
        private Panel panel1;
        private Button loginButton;
        private LinkLabel registerLabel;
    }
}
