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
            logoutButton = new Button();
            resetButton = new Button();
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
            settingsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(resetButton);
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
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 278);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.LightGray;
            logoutButton.Location = new Point(71, 217);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(57, 45);
            logoutButton.TabIndex = 14;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.LightCoral;
            resetButton.Location = new Point(10, 217);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(57, 45);
            resetButton.TabIndex = 13;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // addMacrosButton
            // 
            addMacrosButton.Location = new Point(24, 156);
            addMacrosButton.Name = "addMacrosButton";
            addMacrosButton.Size = new Size(88, 55);
            addMacrosButton.TabIndex = 1;
            addMacrosButton.Text = "Add";
            addMacrosButton.UseVisualStyleBackColor = true;
            addMacrosButton.Click += addMacrosButton_Click;
            // 
            // currentProteinsLabel
            // 
            currentProteinsLabel.AutoSize = true;
            currentProteinsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            currentProteinsLabel.Location = new Point(156, 216);
            currentProteinsLabel.Name = "currentProteinsLabel";
            currentProteinsLabel.Size = new Size(14, 15);
            currentProteinsLabel.TabIndex = 11;
            currentProteinsLabel.Text = "0";
            // 
            // totalProteinsLabel
            // 
            totalProteinsLabel.AutoSize = true;
            totalProteinsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            totalProteinsLabel.Location = new Point(151, 260);
            totalProteinsLabel.Name = "totalProteinsLabel";
            totalProteinsLabel.Size = new Size(50, 15);
            totalProteinsLabel.TabIndex = 10;
            totalProteinsLabel.Text = "Proteins";
            // 
            // proteinsProgressBar
            // 
            proteinsProgressBar.Location = new Point(134, 182);
            proteinsProgressBar.Name = "proteinsProgressBar";
            proteinsProgressBar.Size = new Size(80, 80);
            proteinsProgressBar.TabIndex = 9;
            // 
            // currentFatsLabel
            // 
            currentFatsLabel.AutoSize = true;
            currentFatsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            currentFatsLabel.Location = new Point(156, 123);
            currentFatsLabel.Name = "currentFatsLabel";
            currentFatsLabel.Size = new Size(14, 15);
            currentFatsLabel.TabIndex = 8;
            currentFatsLabel.Text = "0";
            // 
            // totalFatsLabel
            // 
            totalFatsLabel.AutoSize = true;
            totalFatsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            totalFatsLabel.Location = new Point(159, 166);
            totalFatsLabel.Name = "totalFatsLabel";
            totalFatsLabel.Size = new Size(28, 15);
            totalFatsLabel.TabIndex = 7;
            totalFatsLabel.Text = "Fats";
            // 
            // fatsProgressBar
            // 
            fatsProgressBar.Location = new Point(134, 89);
            fatsProgressBar.Name = "fatsProgressBar";
            fatsProgressBar.Size = new Size(80, 80);
            fatsProgressBar.TabIndex = 6;
            // 
            // currentCarbsLabel
            // 
            currentCarbsLabel.AutoSize = true;
            currentCarbsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            currentCarbsLabel.Location = new Point(156, 32);
            currentCarbsLabel.Name = "currentCarbsLabel";
            currentCarbsLabel.Size = new Size(14, 15);
            currentCarbsLabel.TabIndex = 5;
            currentCarbsLabel.Text = "0";
            // 
            // totalCarbsLabel
            // 
            totalCarbsLabel.AutoSize = true;
            totalCarbsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            totalCarbsLabel.Location = new Point(157, 75);
            totalCarbsLabel.Name = "totalCarbsLabel";
            totalCarbsLabel.Size = new Size(36, 15);
            totalCarbsLabel.TabIndex = 4;
            totalCarbsLabel.Text = "Carbs";
            // 
            // carbsProgressBar
            // 
            carbsProgressBar.Location = new Point(134, -2);
            carbsProgressBar.Name = "carbsProgressBar";
            carbsProgressBar.Size = new Size(80, 80);
            carbsProgressBar.TabIndex = 3;
            // 
            // totalCaloriesLabel
            // 
            totalCaloriesLabel.AutoSize = true;
            totalCaloriesLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCaloriesLabel.Location = new Point(42, 123);
            totalCaloriesLabel.Name = "totalCaloriesLabel";
            totalCaloriesLabel.Size = new Size(55, 17);
            totalCaloriesLabel.TabIndex = 2;
            totalCaloriesLabel.Text = "Calories";
            // 
            // currentCaloriesLabel
            // 
            currentCaloriesLabel.AutoSize = true;
            currentCaloriesLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentCaloriesLabel.Location = new Point(53, 55);
            currentCaloriesLabel.Name = "currentCaloriesLabel";
            currentCaloriesLabel.RightToLeft = RightToLeft.No;
            currentCaloriesLabel.Size = new Size(15, 17);
            currentCaloriesLabel.TabIndex = 1;
            currentCaloriesLabel.Text = "0";
            // 
            // caloriesProgressBar
            // 
            caloriesProgressBar.Location = new Point(10, 6);
            caloriesProgressBar.Name = "caloriesProgressBar";
            caloriesProgressBar.Size = new Size(118, 118);
            caloriesProgressBar.TabIndex = 0;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.AutoSize = false;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(57, 24);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.AutoSize = false;
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(48, 24);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.AutoSize = false;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(40, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(52, 24);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(51, 24);
            infoToolStripMenuItem.Text = "About";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 8F);
            menuStrip1.GripMargin = new Padding(0);
            menuStrip1.ImageScalingSize = new Size(10, 10);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, profileToolStripMenuItem, helpToolStripMenuItem, exportToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(248, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(248, 325);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Fitness Manager";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button logoutButton;
    }
}