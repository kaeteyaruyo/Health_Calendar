namespace Health_Calendar
{
    partial class DietPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.calorieText = new System.Windows.Forms.TextBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.kcalLabel = new System.Windows.Forms.Label();
            this.dietLabel = new System.Windows.Forms.Label();
            this.dietText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.mealLabel.Location = new System.Drawing.Point(3, 8);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(130, 24);
            this.mealLabel.TabIndex = 0;
            this.mealLabel.Text = "用餐時段：";
            // 
            // mealComboBox
            // 
            this.mealComboBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "早餐",
            "午餐",
            "晚餐",
            "其他"});
            this.mealComboBox.Location = new System.Drawing.Point(133, 5);
            this.mealComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(203, 32);
            this.mealComboBox.TabIndex = 1;
            this.mealComboBox.SelectedIndexChanged += new System.EventHandler(this.mealComboBox_SelectedIndexChanged);
            // 
            // calorieText
            // 
            this.calorieText.Font = new System.Drawing.Font("新細明體", 12F);
            this.calorieText.Location = new System.Drawing.Point(133, 49);
            this.calorieText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calorieText.Name = "calorieText";
            this.calorieText.Size = new System.Drawing.Size(203, 36);
            this.calorieText.TabIndex = 2;
            this.calorieText.TextChanged += new System.EventHandler(this.calorieText_TextChanged);
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.calorieLabel.Location = new System.Drawing.Point(3, 53);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(130, 24);
            this.calorieLabel.TabIndex = 0;
            this.calorieLabel.Text = "攝取熱量：";
            // 
            // kcalLabel
            // 
            this.kcalLabel.AutoSize = true;
            this.kcalLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.kcalLabel.Location = new System.Drawing.Point(343, 53);
            this.kcalLabel.Name = "kcalLabel";
            this.kcalLabel.Size = new System.Drawing.Size(58, 24);
            this.kcalLabel.TabIndex = 0;
            this.kcalLabel.Text = "大卡";
            // 
            // dietLabel
            // 
            this.dietLabel.AutoSize = true;
            this.dietLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.dietLabel.Location = new System.Drawing.Point(3, 100);
            this.dietLabel.Name = "dietLabel";
            this.dietLabel.Size = new System.Drawing.Size(130, 24);
            this.dietLabel.TabIndex = 0;
            this.dietLabel.Text = "用餐內容：";
            // 
            // dietText
            // 
            this.dietText.Font = new System.Drawing.Font("新細明體", 12F);
            this.dietText.Location = new System.Drawing.Point(8, 134);
            this.dietText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dietText.Multiline = true;
            this.dietText.Name = "dietText";
            this.dietText.Size = new System.Drawing.Size(452, 274);
            this.dietText.TabIndex = 3;
            this.dietText.TextChanged += new System.EventHandler(this.dietText_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(426, 5);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 36);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DietPanel
            // 
           // this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
           // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.kcalLabel);
            this.Controls.Add(this.dietText);
            this.Controls.Add(this.dietLabel);
            this.Controls.Add(this.calorieText);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.mealLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DietPanel";
            this.Size = new System.Drawing.Size(470, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.TextBox calorieText;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.TextBox dietText;
        private System.Windows.Forms.Label dietLabel;
        private System.Windows.Forms.Label kcalLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox mealComboBox;
    }
}


