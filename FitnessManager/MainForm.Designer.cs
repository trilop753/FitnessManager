namespace FitnessManager
{
    partial class MainForm
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
            panel1 = new Panel();
            resetButton = new Button();
            activityButton = new Button();
            addMacrosButton = new Button();
            currentProteinsLabel = new Label();
            totalProteinsLabel = new Label();
            proteinsProgressBar = new CircularProgressBar();
            currentFatsLabel = new Label();
            totalFatsLabel = new Label();
            fatsProgressBar = new CircularProgressBar();
            currentCarbsLabel = new Label();
            totalCarbsLabel = new Label();
            carbsProgressBar = new CircularProgressBar();
            totalCaloriesLabel = new Label();
            currentCaloriesLabel = new Label();
            caloriesProgressBar = new CircularProgressBar();
            panel2 = new Panel();
            button2 = new Button();
            settingsButton = new Button();
            loggedAsLabel = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(activityButton);
            panel1.Controls.Add(addMacrosButton);
            panel1.Controls.Add(currentProteinsLabel);
            panel1.Controls.Add(totalProteinsLabel);
            panel1.Controls.Add(proteinsProgressBar);
            panel1.Controls.Add(currentFatsLabel);
            panel1.Controls.Add(totalFatsLabel);
            panel1.Controls.Add(fatsProgressBar);
            panel1.Controls.Add(currentCarbsLabel);
            panel1.Controls.Add(totalCarbsLabel);
            panel1.Controls.Add(carbsProgressBar);
            panel1.Controls.Add(totalCaloriesLabel);
            panel1.Controls.Add(currentCaloriesLabel);
            panel1.Controls.Add(caloriesProgressBar);
            panel1.Location = new Point(218, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 262);
            panel1.TabIndex = 0;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.LightCoral;
            resetButton.Location = new Point(19, 205);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(59, 35);
            resetButton.TabIndex = 13;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // activityButton
            // 
            activityButton.BackColor = SystemColors.ActiveBorder;
            activityButton.Location = new Point(19, 164);
            activityButton.Name = "activityButton";
            activityButton.Size = new Size(59, 35);
            activityButton.TabIndex = 12;
            activityButton.Text = "TBA";
            activityButton.UseVisualStyleBackColor = false;
            activityButton.Click += activityButton_Click;
            // 
            // addMacrosButton
            // 
            addMacrosButton.Location = new Point(19, 123);
            addMacrosButton.Name = "addMacrosButton";
            addMacrosButton.Size = new Size(59, 35);
            addMacrosButton.TabIndex = 1;
            addMacrosButton.Text = "Add";
            addMacrosButton.UseVisualStyleBackColor = true;
            addMacrosButton.Click += addMacrosButton_Click;
            // 
            // currentProteinsLabel
            // 
            currentProteinsLabel.AutoSize = true;
            currentProteinsLabel.Location = new Point(130, 202);
            currentProteinsLabel.Name = "currentProteinsLabel";
            currentProteinsLabel.Size = new Size(13, 15);
            currentProteinsLabel.TabIndex = 11;
            currentProteinsLabel.Text = "0";
            // 
            // totalProteinsLabel
            // 
            totalProteinsLabel.AutoSize = true;
            totalProteinsLabel.Location = new Point(123, 241);
            totalProteinsLabel.Name = "totalProteinsLabel";
            totalProteinsLabel.Size = new Size(50, 15);
            totalProteinsLabel.TabIndex = 10;
            totalProteinsLabel.Text = "Proteins";
            // 
            // proteinsProgressBar
            // 
            proteinsProgressBar.Location = new Point(113, 174);
            proteinsProgressBar.Name = "proteinsProgressBar";
            proteinsProgressBar.Size = new Size(70, 70);
            proteinsProgressBar.TabIndex = 9;
            // 
            // currentFatsLabel
            // 
            currentFatsLabel.AutoSize = true;
            currentFatsLabel.Location = new Point(130, 116);
            currentFatsLabel.Name = "currentFatsLabel";
            currentFatsLabel.Size = new Size(13, 15);
            currentFatsLabel.TabIndex = 8;
            currentFatsLabel.Text = "0";
            // 
            // totalFatsLabel
            // 
            totalFatsLabel.AutoSize = true;
            totalFatsLabel.Location = new Point(134, 157);
            totalFatsLabel.Name = "totalFatsLabel";
            totalFatsLabel.Size = new Size(28, 15);
            totalFatsLabel.TabIndex = 7;
            totalFatsLabel.Text = "Fats";
            // 
            // fatsProgressBar
            // 
            fatsProgressBar.Location = new Point(113, 88);
            fatsProgressBar.Name = "fatsProgressBar";
            fatsProgressBar.Size = new Size(70, 70);
            fatsProgressBar.TabIndex = 6;
            // 
            // currentCarbsLabel
            // 
            currentCarbsLabel.AutoSize = true;
            currentCarbsLabel.Location = new Point(130, 30);
            currentCarbsLabel.Name = "currentCarbsLabel";
            currentCarbsLabel.Size = new Size(13, 15);
            currentCarbsLabel.TabIndex = 5;
            currentCarbsLabel.Text = "0";
            // 
            // totalCarbsLabel
            // 
            totalCarbsLabel.AutoSize = true;
            totalCarbsLabel.Location = new Point(130, 70);
            totalCarbsLabel.Name = "totalCarbsLabel";
            totalCarbsLabel.Size = new Size(37, 15);
            totalCarbsLabel.TabIndex = 4;
            totalCarbsLabel.Text = "Carbs";
            // 
            // carbsProgressBar
            // 
            carbsProgressBar.Location = new Point(113, 3);
            carbsProgressBar.Name = "carbsProgressBar";
            carbsProgressBar.Size = new Size(70, 70);
            carbsProgressBar.TabIndex = 3;
            // 
            // totalCaloriesLabel
            // 
            totalCaloriesLabel.AutoSize = true;
            totalCaloriesLabel.Location = new Point(29, 56);
            totalCaloriesLabel.Name = "totalCaloriesLabel";
            totalCaloriesLabel.Size = new Size(49, 15);
            totalCaloriesLabel.TabIndex = 2;
            totalCaloriesLabel.Text = "Calories";
            // 
            // currentCaloriesLabel
            // 
            currentCaloriesLabel.AutoSize = true;
            currentCaloriesLabel.Location = new Point(38, 41);
            currentCaloriesLabel.Name = "currentCaloriesLabel";
            currentCaloriesLabel.RightToLeft = RightToLeft.No;
            currentCaloriesLabel.Size = new Size(13, 15);
            currentCaloriesLabel.TabIndex = 1;
            currentCaloriesLabel.Text = "0";
            // 
            // caloriesProgressBar
            // 
            caloriesProgressBar.Location = new Point(3, 3);
            caloriesProgressBar.Name = "caloriesProgressBar";
            caloriesProgressBar.Size = new Size(100, 100);
            caloriesProgressBar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(settingsButton);
            panel2.Controls.Add(loggedAsLabel);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 128);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(107, 77);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(107, 33);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(75, 38);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // loggedAsLabel
            // 
            loggedAsLabel.AutoSize = true;
            loggedAsLabel.Font = new Font("Segoe UI", 10F);
            loggedAsLabel.Location = new Point(3, 3);
            loggedAsLabel.Name = "loggedAsLabel";
            loggedAsLabel.Size = new Size(94, 19);
            loggedAsLabel.TabIndex = 0;
            loggedAsLabel.Text = "Logged in as: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Location = new Point(12, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 128);
            panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(420, 285);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CircularProgressBar caloriesProgressBar;
        private Button addMacrosButton;
        private Label currentCaloriesLabel;
        private Label totalCaloriesLabel;
        private Label currentCarbsLabel;
        private Label totalCarbsLabel;
        private CircularProgressBar carbsProgressBar;
        private Label currentFatsLabel;
        private Label totalFatsLabel;
        private CircularProgressBar fatsProgressBar;
        private Label currentProteinsLabel;
        private Label totalProteinsLabel;
        private CircularProgressBar proteinsProgressBar;
        private Button resetButton;
        private Button activityButton;
        private Panel panel2;
        private Panel panel3;
        private Label loggedAsLabel;
        private Button settingsButton;
        private Button button2;
    }
}