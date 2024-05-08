namespace FitnessManager
{
    partial class AddForm
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
            gramsBox = new TextBox();
            searchBox = new TextBox();
            foods = new ListBox();
            addMacrosButton = new Button();
            addProteinsBox = new TextBox();
            addFatsBox = new TextBox();
            addCarbsBox = new TextBox();
            addCaloriesBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(gramsBox);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(foods);
            panel1.Controls.Add(addMacrosButton);
            panel1.Controls.Add(addProteinsBox);
            panel1.Controls.Add(addFatsBox);
            panel1.Controls.Add(addCarbsBox);
            panel1.Controls.Add(addCaloriesBox);
            panel1.Location = new Point(12, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 164);
            panel1.TabIndex = 0;
            // 
            // gramsBox
            // 
            gramsBox.Font = new Font("Segoe UI", 9F);
            gramsBox.Location = new Point(230, 2);
            gramsBox.Name = "gramsBox";
            gramsBox.PlaceholderText = "0 g";
            gramsBox.Size = new Size(62, 23);
            gramsBox.TabIndex = 8;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(124, 2);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "search";
            searchBox.Size = new Size(100, 23);
            searchBox.TabIndex = 7;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // foods
            // 
            foods.FormattingEnabled = true;
            foods.ItemHeight = 15;
            foods.Location = new Point(124, 32);
            foods.Name = "foods";
            foods.Size = new Size(168, 124);
            foods.TabIndex = 6;
            foods.SelectedIndexChanged += foods_SelectedChanged;
            // 
            // addMacrosButton
            // 
            addMacrosButton.Location = new Point(3, 119);
            addMacrosButton.Name = "addMacrosButton";
            addMacrosButton.Size = new Size(100, 40);
            addMacrosButton.TabIndex = 4;
            addMacrosButton.Text = "Add";
            addMacrosButton.UseVisualStyleBackColor = true;
            addMacrosButton.Click += addMacrosButton_Click;
            // 
            // addProteinsBox
            // 
            addProteinsBox.Location = new Point(3, 90);
            addProteinsBox.Name = "addProteinsBox";
            addProteinsBox.PlaceholderText = "Proteins";
            addProteinsBox.Size = new Size(100, 23);
            addProteinsBox.TabIndex = 3;
            // 
            // addFatsBox
            // 
            addFatsBox.Location = new Point(3, 61);
            addFatsBox.Name = "addFatsBox";
            addFatsBox.PlaceholderText = "Fats";
            addFatsBox.Size = new Size(100, 23);
            addFatsBox.TabIndex = 2;
            // 
            // addCarbsBox
            // 
            addCarbsBox.Location = new Point(3, 32);
            addCarbsBox.Name = "addCarbsBox";
            addCarbsBox.PlaceholderText = "Carbohydrates";
            addCarbsBox.Size = new Size(100, 23);
            addCarbsBox.TabIndex = 1;
            // 
            // addCaloriesBox
            // 
            addCaloriesBox.Location = new Point(3, 3);
            addCaloriesBox.Name = "addCaloriesBox";
            addCaloriesBox.PlaceholderText = "Calories";
            addCaloriesBox.Size = new Size(100, 23);
            addCaloriesBox.TabIndex = 0;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(319, 184);
            Controls.Add(panel1);
            Name = "AddForm";
            Text = "Adding macros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox addCaloriesBox;
        private TextBox addProteinsBox;
        private TextBox addFatsBox;
        private TextBox addCarbsBox;
        private Button addMacrosButton;
        private ListBox foods;
        private TextBox searchBox;
        private TextBox gramsBox;
    }
}