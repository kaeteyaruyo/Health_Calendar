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
            this.mealLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.mealLabel.Location = new System.Drawing.Point(3, 7);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(109, 20);
            this.mealLabel.TabIndex = 0;
            this.mealLabel.Text = "用餐時段：";
            // 
            // mealComboBox
            // 
            this.mealComboBox.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "早餐",
            "午餐",
            "晚餐",
            "其他"});
            this.mealComboBox.Location = new System.Drawing.Point(118, 4);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(181, 28);
            this.mealComboBox.TabIndex = 1;
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.calorieLabel.Location = new System.Drawing.Point(3, 44);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(109, 20);
            this.calorieLabel.TabIndex = 0;
            this.calorieLabel.Text = "攝取熱量：";
            // 
            // calorieText
            // 
            this.calorieText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.calorieText.Location = new System.Drawing.Point(118, 41);
            this.calorieText.Name = "calorieText";
            this.calorieText.Size = new System.Drawing.Size(181, 31);
            this.calorieText.TabIndex = 2;
            // 
            // kcalLabel
            // 
            this.kcalLabel.AutoSize = true;
            this.kcalLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.kcalLabel.Location = new System.Drawing.Point(305, 44);
            this.kcalLabel.Name = "kcalLabel";
            this.kcalLabel.Size = new System.Drawing.Size(49, 20);
            this.kcalLabel.TabIndex = 0;
            this.kcalLabel.Text = "大卡";
            // 
            // dietLabel
            // 
            this.dietLabel.AutoSize = true;
            this.dietLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.dietLabel.Location = new System.Drawing.Point(3, 83);
            this.dietLabel.Name = "dietLabel";
            this.dietLabel.Size = new System.Drawing.Size(109, 20);
            this.dietLabel.TabIndex = 0;
            this.dietLabel.Text = "用餐內容：";
            // 
            // dietText
            // 
            this.dietText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.dietText.Location = new System.Drawing.Point(7, 112);
            this.dietText.Multiline = true;
            this.dietText.Name = "dietText";
            this.dietText.Size = new System.Drawing.Size(402, 229);
            this.dietText.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(379, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // DietPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.kcalLabel);
            this.Controls.Add(this.dietText);
            this.Controls.Add(this.dietLabel);
            this.Controls.Add(this.calorieText);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.mealLabel);
            this.Name = "DietPanel";
            this.Size = new System.Drawing.Size(416, 349);
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


