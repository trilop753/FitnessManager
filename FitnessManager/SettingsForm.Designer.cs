namespace FitnessManager
{
    partial class SettingsForm
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
            accountUpdateButton = new Button();
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
            ageLabel = new Label();
            ageBox = new TextBox();
            weightLabel = new Label();
            weightBox = new TextBox();
            heightBox = new TextBox();
            heightLabel = new Label();
            accountSettingsLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            macrosUpdateButton = new Button();
            proteinsPlusButton = new Button();
            fatsPlusButton = new Button();
            carbsPlusButton = new Button();
            caloriesPlusButton = new Button();
            proteinsMinusButton = new Button();
            fatsMinusButton = new Button();
            carbsMinusButton = new Button();
            caloriesMinusButton = new Button();
            proteinsLabel = new Label();
            fatsLabel = new Label();
            carbsLabel = new Label();
            caloriesLabel = new Label();
            label1 = new Label();
            wantPanel.SuspendLayout();
            lifestylePanel.SuspendLayout();
            genderPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // accountUpdateButton
            // 
            accountUpdateButton.Location = new Point(102, 210);
            accountUpdateButton.Name = "accountUpdateButton";
            accountUpdateButton.Size = new Size(101, 33);
            accountUpdateButton.TabIndex = 103;
            accountUpdateButton.Text = "Save";
            accountUpdateButton.UseVisualStyleBackColor = true;
            accountUpdateButton.Click += accountUpdateButton_Click;
            // 
            // wantPanel
            // 
            wantPanel.Controls.Add(wantLabel);
            wantPanel.Controls.Add(muscleButton);
            wantPanel.Controls.Add(fatButton);
            wantPanel.Location = new Point(96, 140);
            wantPanel.Name = "wantPanel";
            wantPanel.Size = new Size(107, 64);
            wantPanel.TabIndex = 102;
            // 
            // wantLabel
            // 
            wantLabel.AutoSize = true;
            wantLabel.Location = new Point(6, 0);
            wantLabel.Name = "wantLabel";
            wantLabel.Size = new Size(91, 15);
            wantLabel.TabIndex = 19;
            wantLabel.Text = "Do you want to:";
            // 
            // muscleButton
            // 
            muscleButton.AutoSize = true;
            muscleButton.Location = new Point(12, 20);
            muscleButton.Name = "muscleButton";
            muscleButton.Size = new Size(95, 19);
            muscleButton.TabIndex = 11;
            muscleButton.TabStop = true;
            muscleButton.Text = "Gain muscles";
            muscleButton.UseVisualStyleBackColor = true;
            // 
            // fatButton
            // 
            fatButton.AutoSize = true;
            fatButton.Location = new Point(12, 45);
            fatButton.Name = "fatButton";
            fatButton.Size = new Size(66, 19);
            fatButton.TabIndex = 12;
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
            lifestylePanel.Location = new Point(2, 138);
            lifestylePanel.Name = "lifestylePanel";
            lifestylePanel.Size = new Size(88, 89);
            lifestylePanel.TabIndex = 101;
            // 
            // lifestyleLabel
            // 
            lifestyleLabel.AutoSize = true;
            lifestyleLabel.Location = new Point(8, 2);
            lifestyleLabel.Name = "lifestyleLabel";
            lifestyleLabel.Size = new Size(53, 15);
            lifestyleLabel.TabIndex = 16;
            lifestyleLabel.Text = "Lifestyle:";
            // 
            // sedentaryButton
            // 
            sedentaryButton.AutoSize = true;
            sedentaryButton.Location = new Point(14, 20);
            sedentaryButton.Name = "sedentaryButton";
            sedentaryButton.Size = new Size(80, 19);
            sedentaryButton.TabIndex = 8;
            sedentaryButton.TabStop = true;
            sedentaryButton.Text = "Sedentary ";
            sedentaryButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            mediumButton.AutoSize = true;
            mediumButton.Location = new Point(14, 45);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(70, 19);
            mediumButton.TabIndex = 9;
            mediumButton.TabStop = true;
            mediumButton.Text = "Medium";
            mediumButton.UseVisualStyleBackColor = true;
            // 
            // activeButton
            // 
            activeButton.AutoSize = true;
            activeButton.Location = new Point(14, 70);
            activeButton.Name = "activeButton";
            activeButton.Size = new Size(58, 19);
            activeButton.TabIndex = 10;
            activeButton.TabStop = true;
            activeButton.Text = "Active";
            activeButton.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(femaleButton);
            genderPanel.Controls.Add(maleButton);
            genderPanel.Location = new Point(36, 106);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(137, 26);
            genderPanel.TabIndex = 101;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Location = new Point(71, 4);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(63, 19);
            femaleButton.TabIndex = 7;
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
            maleButton.TabIndex = 6;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(36, 88);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(28, 15);
            ageLabel.TabIndex = 18;
            ageLabel.Text = "Age";
            ageLabel.UseMnemonic = false;
            // 
            // ageBox
            // 
            ageBox.Location = new Point(73, 85);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(100, 23);
            ageBox.TabIndex = 15;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(22, 59);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(45, 15);
            weightLabel.TabIndex = 17;
            weightLabel.Text = "Weight";
            // 
            // weightBox
            // 
            weightBox.Location = new Point(73, 56);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(100, 23);
            weightBox.TabIndex = 14;
            // 
            // heightBox
            // 
            heightBox.Location = new Point(73, 27);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(100, 23);
            heightBox.TabIndex = 13;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(24, 30);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(43, 15);
            heightLabel.TabIndex = 16;
            heightLabel.Text = "Height";
            // 
            // accountSettingsLabel
            // 
            accountSettingsLabel.AutoSize = true;
            accountSettingsLabel.Location = new Point(55, 3);
            accountSettingsLabel.Name = "accountSettingsLabel";
            accountSettingsLabel.Size = new Size(96, 15);
            accountSettingsLabel.TabIndex = 0;
            accountSettingsLabel.Text = "Account settings";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(213, 274);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleGreen;
            tabPage1.Controls.Add(accountUpdateButton);
            tabPage1.Controls.Add(weightBox);
            tabPage1.Controls.Add(wantPanel);
            tabPage1.Controls.Add(accountSettingsLabel);
            tabPage1.Controls.Add(lifestylePanel);
            tabPage1.Controls.Add(heightLabel);
            tabPage1.Controls.Add(genderPanel);
            tabPage1.Controls.Add(heightBox);
            tabPage1.Controls.Add(ageLabel);
            tabPage1.Controls.Add(weightLabel);
            tabPage1.Controls.Add(ageBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(205, 246);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleGreen;
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(macrosUpdateButton);
            tabPage2.Controls.Add(proteinsPlusButton);
            tabPage2.Controls.Add(fatsPlusButton);
            tabPage2.Controls.Add(carbsPlusButton);
            tabPage2.Controls.Add(caloriesPlusButton);
            tabPage2.Controls.Add(proteinsMinusButton);
            tabPage2.Controls.Add(fatsMinusButton);
            tabPage2.Controls.Add(carbsMinusButton);
            tabPage2.Controls.Add(caloriesMinusButton);
            tabPage2.Controls.Add(proteinsLabel);
            tabPage2.Controls.Add(fatsLabel);
            tabPage2.Controls.Add(carbsLabel);
            tabPage2.Controls.Add(caloriesLabel);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(205, 246);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Macronutrients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 158);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 18;
            label5.Text = "Proteins";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 117);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 17;
            label4.Text = "Fats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 74);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 16;
            label3.Text = "Carbs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Calories";
            // 
            // macrosUpdateButton
            // 
            macrosUpdateButton.Location = new Point(51, 198);
            macrosUpdateButton.Name = "macrosUpdateButton";
            macrosUpdateButton.Size = new Size(103, 42);
            macrosUpdateButton.TabIndex = 14;
            macrosUpdateButton.Text = "Save";
            macrosUpdateButton.UseVisualStyleBackColor = true;
            macrosUpdateButton.Click += macrosUpdateButton_Click;
            // 
            // proteinsPlusButton
            // 
            proteinsPlusButton.Location = new Point(145, 169);
            proteinsPlusButton.Name = "proteinsPlusButton";
            proteinsPlusButton.Size = new Size(35, 23);
            proteinsPlusButton.TabIndex = 13;
            proteinsPlusButton.Text = "+";
            proteinsPlusButton.UseVisualStyleBackColor = true;
            proteinsPlusButton.Click += proteinsPlusButton_Click;
            // 
            // fatsPlusButton
            // 
            fatsPlusButton.Location = new Point(145, 128);
            fatsPlusButton.Name = "fatsPlusButton";
            fatsPlusButton.Size = new Size(35, 23);
            fatsPlusButton.TabIndex = 12;
            fatsPlusButton.Text = "+";
            fatsPlusButton.UseVisualStyleBackColor = true;
            fatsPlusButton.Click += fatsPlusButton_Click;
            // 
            // carbsPlusButton
            // 
            carbsPlusButton.Location = new Point(145, 85);
            carbsPlusButton.Name = "carbsPlusButton";
            carbsPlusButton.Size = new Size(35, 23);
            carbsPlusButton.TabIndex = 11;
            carbsPlusButton.Text = "+";
            carbsPlusButton.UseVisualStyleBackColor = true;
            carbsPlusButton.Click += carbsPlusButton_Click;
            // 
            // caloriesPlusButton
            // 
            caloriesPlusButton.Location = new Point(145, 43);
            caloriesPlusButton.Name = "caloriesPlusButton";
            caloriesPlusButton.Size = new Size(35, 23);
            caloriesPlusButton.TabIndex = 10;
            caloriesPlusButton.Text = "+";
            caloriesPlusButton.UseVisualStyleBackColor = true;
            caloriesPlusButton.Click += caloriesPlusButton_Click;
            // 
            // proteinsMinusButton
            // 
            proteinsMinusButton.Location = new Point(23, 169);
            proteinsMinusButton.Name = "proteinsMinusButton";
            proteinsMinusButton.Size = new Size(35, 23);
            proteinsMinusButton.TabIndex = 9;
            proteinsMinusButton.Text = "-";
            proteinsMinusButton.UseVisualStyleBackColor = true;
            proteinsMinusButton.Click += proteinsMinusButton_Click;
            // 
            // fatsMinusButton
            // 
            fatsMinusButton.Location = new Point(23, 128);
            fatsMinusButton.Name = "fatsMinusButton";
            fatsMinusButton.Size = new Size(35, 23);
            fatsMinusButton.TabIndex = 8;
            fatsMinusButton.Text = "-";
            fatsMinusButton.UseVisualStyleBackColor = true;
            fatsMinusButton.Click += fatsMinusButton_Click;
            // 
            // carbsMinusButton
            // 
            carbsMinusButton.Location = new Point(23, 85);
            carbsMinusButton.Name = "carbsMinusButton";
            carbsMinusButton.Size = new Size(35, 23);
            carbsMinusButton.TabIndex = 7;
            carbsMinusButton.Text = "-";
            carbsMinusButton.UseVisualStyleBackColor = true;
            carbsMinusButton.Click += carbsMinusButton_Click;
            // 
            // caloriesMinusButton
            // 
            caloriesMinusButton.Location = new Point(23, 43);
            caloriesMinusButton.Name = "caloriesMinusButton";
            caloriesMinusButton.Size = new Size(35, 23);
            caloriesMinusButton.TabIndex = 6;
            caloriesMinusButton.Text = "-";
            caloriesMinusButton.UseVisualStyleBackColor = true;
            caloriesMinusButton.Click += caloriesMinusButton_Click;
            // 
            // proteinsLabel
            // 
            proteinsLabel.AutoSize = true;
            proteinsLabel.Location = new Point(78, 173);
            proteinsLabel.Name = "proteinsLabel";
            proteinsLabel.Size = new Size(13, 15);
            proteinsLabel.TabIndex = 5;
            proteinsLabel.Text = "0";
            // 
            // fatsLabel
            // 
            fatsLabel.AutoSize = true;
            fatsLabel.Location = new Point(78, 132);
            fatsLabel.Name = "fatsLabel";
            fatsLabel.Size = new Size(13, 15);
            fatsLabel.TabIndex = 4;
            fatsLabel.Text = "0";
            // 
            // carbsLabel
            // 
            carbsLabel.AutoSize = true;
            carbsLabel.Location = new Point(78, 89);
            carbsLabel.Name = "carbsLabel";
            carbsLabel.Size = new Size(13, 15);
            carbsLabel.TabIndex = 3;
            carbsLabel.Text = "0";
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Location = new Point(78, 47);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(13, 15);
            caloriesLabel.TabIndex = 2;
            caloriesLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 3);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "Macronutrients settings";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(238, 300);
            Controls.Add(tabControl1);
            Name = "SettingsForm";
            Text = "SettingsForm";
            wantPanel.ResumeLayout(false);
            wantPanel.PerformLayout();
            lifestylePanel.ResumeLayout(false);
            lifestylePanel.PerformLayout();
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label accountSettingsLabel;
        private Label ageLabel;
        private TextBox ageBox;
        private Label weightLabel;
        private TextBox weightBox;
        private TextBox heightBox;
        private Label heightLabel;
        private Panel genderPanel;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private Panel lifestylePanel;
        private Label lifestyleLabel;
        private RadioButton sedentaryButton;
        private RadioButton mediumButton;
        private RadioButton activeButton;
        private Button accountUpdateButton;
        private Panel wantPanel;
        private Label wantLabel;
        private RadioButton muscleButton;
        private RadioButton fatButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button caloriesMinusButton;
        private Label proteinsLabel;
        private Label fatsLabel;
        private Label carbsLabel;
        private Label caloriesLabel;
        private Button macrosUpdateButton;
        private Button proteinsPlusButton;
        private Button fatsPlusButton;
        private Button carbsPlusButton;
        private Button caloriesPlusButton;
        private Button proteinsMinusButton;
        private Button fatsMinusButton;
        private Button carbsMinusButton;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}