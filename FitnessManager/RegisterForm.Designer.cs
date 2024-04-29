namespace FitnessManager
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bigPanel = new Panel();
            wantPanel = new Panel();
            wantLabel = new Label();
            muscleButton = new RadioButton();
            fatButton = new RadioButton();
            lifestylePanel = new Panel();
            lifestyleLabel = new Label();
            sedentaryButton = new RadioButton();
            mediumButton = new RadioButton();
            activeButton = new RadioButton();
            genderPanel = new Panel();
            femaleButton = new RadioButton();
            maleButton = new RadioButton();
            weightLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            heightLabel = new Label();
            registerButton = new Button();
            passwordLabel = new Label();
            bigRegisterLabel = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            usernameLabel = new Label();
            bigPanel.SuspendLayout();
            wantPanel.SuspendLayout();
            lifestylePanel.SuspendLayout();
            genderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bigPanel
            // 
            bigPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bigPanel.BackColor = Color.PaleGreen;
            bigPanel.Controls.Add(wantPanel);
            bigPanel.Controls.Add(lifestylePanel);
            bigPanel.Controls.Add(genderPanel);
            bigPanel.Controls.Add(weightLabel);
            bigPanel.Controls.Add(textBox1);
            bigPanel.Controls.Add(textBox2);
            bigPanel.Controls.Add(heightLabel);
            bigPanel.Controls.Add(registerButton);
            bigPanel.Controls.Add(passwordLabel);
            bigPanel.Controls.Add(bigRegisterLabel);
            bigPanel.Controls.Add(passwordBox);
            bigPanel.Controls.Add(usernameBox);
            bigPanel.Controls.Add(usernameLabel);
            bigPanel.Location = new Point(153, 113);
            bigPanel.Name = "bigPanel";
            bigPanel.Size = new Size(403, 303);
            bigPanel.TabIndex = 7;
            // 
            // wantPanel
            // 
            wantPanel.Controls.Add(wantLabel);
            wantPanel.Controls.Add(muscleButton);
            wantPanel.Controls.Add(fatButton);
            wantPanel.Location = new Point(235, 168);
            wantPanel.Name = "wantPanel";
            wantPanel.Size = new Size(123, 87);
            wantPanel.TabIndex = 7;
            // 
            // wantLabel
            // 
            wantLabel.AutoSize = true;
            wantLabel.Location = new Point(17, 13);
            wantLabel.Name = "wantLabel";
            wantLabel.Size = new Size(91, 15);
            wantLabel.TabIndex = 19;
            wantLabel.Text = "Do you want to:";
            // 
            // muscleButton
            // 
            muscleButton.AutoSize = true;
            muscleButton.Location = new Point(28, 31);
            muscleButton.Name = "muscleButton";
            muscleButton.Size = new Size(95, 19);
            muscleButton.TabIndex = 17;
            muscleButton.TabStop = true;
            muscleButton.Text = "Gain muscles";
            muscleButton.UseVisualStyleBackColor = true;
            // 
            // fatButton
            // 
            fatButton.AutoSize = true;
            fatButton.Location = new Point(28, 56);
            fatButton.Name = "fatButton";
            fatButton.Size = new Size(66, 19);
            fatButton.TabIndex = 18;
            fatButton.TabStop = true;
            fatButton.Text = "Lose fat";
            fatButton.UseVisualStyleBackColor = true;
            // 
            // lifestylePanel
            // 
            lifestylePanel.Controls.Add(lifestyleLabel);
            lifestylePanel.Controls.Add(sedentaryButton);
            lifestylePanel.Controls.Add(mediumButton);
            lifestylePanel.Controls.Add(activeButton);
            lifestylePanel.Location = new Point(227, 62);
            lifestylePanel.Name = "lifestylePanel";
            lifestylePanel.Size = new Size(119, 100);
            lifestylePanel.TabIndex = 6;
            // 
            // lifestyleLabel
            // 
            lifestyleLabel.AutoSize = true;
            lifestyleLabel.Location = new Point(8, 2);
            lifestyleLabel.Name = "lifestyleLabel";
            lifestyleLabel.Size = new Size(111, 15);
            lifestyleLabel.TabIndex = 16;
            lifestyleLabel.Text = "Select your lifestyle:";
            // 
            // sedentaryButton
            // 
            sedentaryButton.AutoSize = true;
            sedentaryButton.Location = new Point(36, 20);
            sedentaryButton.Name = "sedentaryButton";
            sedentaryButton.Size = new Size(80, 19);
            sedentaryButton.TabIndex = 13;
            sedentaryButton.TabStop = true;
            sedentaryButton.Text = "Sedentary ";
            sedentaryButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            mediumButton.AutoSize = true;
            mediumButton.Location = new Point(36, 45);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(70, 19);
            mediumButton.TabIndex = 14;
            mediumButton.TabStop = true;
            mediumButton.Text = "Medium";
            mediumButton.UseVisualStyleBackColor = true;
            // 
            // activeButton
            // 
            activeButton.AutoSize = true;
            activeButton.Location = new Point(36, 70);
            activeButton.Name = "activeButton";
            activeButton.Size = new Size(58, 19);
            activeButton.TabIndex = 15;
            activeButton.TabStop = true;
            activeButton.Text = "Active";
            activeButton.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(femaleButton);
            genderPanel.Controls.Add(maleButton);
            genderPanel.Location = new Point(47, 178);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(137, 26);
            genderPanel.TabIndex = 5;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Location = new Point(71, 4);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(63, 19);
            femaleButton.TabIndex = 12;
            femaleButton.TabStop = true;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Location = new Point(3, 4);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(51, 19);
            maleButton.TabIndex = 11;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(33, 152);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(45, 15);
            weightLabel.TabIndex = 10;
            weightLabel.Text = "Weight";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(35, 123);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(43, 15);
            heightLabel.TabIndex = 7;
            heightLabel.Text = "Height";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(149, 225);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(57, 30);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(21, 94);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // bigRegisterLabel
            // 
            bigRegisterLabel.AutoSize = true;
            bigRegisterLabel.Font = new Font("Segoe UI", 15F);
            bigRegisterLabel.Location = new Point(149, 15);
            bigRegisterLabel.Name = "bigRegisterLabel";
            bigRegisterLabel.Size = new Size(96, 28);
            bigRegisterLabel.TabIndex = 0;
            bigRegisterLabel.Text = "REGISTER";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(84, 91);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 2;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(84, 62);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(18, 65);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(734, 561);
            Controls.Add(bigPanel);
            Name = "RegisterForm";
            Text = "RegisterForm";
            bigPanel.ResumeLayout(false);
            bigPanel.PerformLayout();
            wantPanel.ResumeLayout(false);
            wantPanel.PerformLayout();
            lifestylePanel.ResumeLayout(false);
            lifestylePanel.PerformLayout();
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bigPanel;
        private Button registerButton;
        private Label weightLabel;
        private Label passwordLabel;
        private Label bigRegisterLabel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Label usernameLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label heightLabel;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private RadioButton activeButton;
        private RadioButton mediumButton;
        private RadioButton sedentaryButton;
        private Label wantLabel;
        private RadioButton fatButton;
        private RadioButton muscleButton;
        private Label lifestyleLabel;
        private Panel genderPanel;
        private Panel wantPanel;
        private Panel lifestylePanel;
    }
}