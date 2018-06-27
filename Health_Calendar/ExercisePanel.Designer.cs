namespace Health_Calendar
{
    partial class ExercisePanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.timeLengthText = new System.Windows.Forms.TextBox();
            this.timeLengthLabel = new System.Windows.Forms.Label();
            this.calorieText = new System.Windows.Forms.TextBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.kcalLabel = new System.Windows.Forms.Label();
            this.detailText = new System.Windows.Forms.TextBox();
            this.detailLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.titleLabel.Location = new System.Drawing.Point(3, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(109, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "運動項目：";
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.titleText.Location = new System.Drawing.Point(118, 4);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(181, 31);
            this.titleText.TabIndex = 1;
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // timeLengthText
            // 
            this.timeLengthText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.timeLengthText.Location = new System.Drawing.Point(118, 45);
            this.timeLengthText.Name = "timeLengthText";
            this.timeLengthText.Size = new System.Drawing.Size(181, 31);
            this.timeLengthText.TabIndex = 2;
            this.timeLengthText.TextChanged += new System.EventHandler(this.timeLengthText_TextChanged);
            // 
            // timeLengthLabel
            // 
            this.timeLengthLabel.AutoSize = true;
            this.timeLengthLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.timeLengthLabel.Location = new System.Drawing.Point(3, 48);
            this.timeLengthLabel.Name = "timeLengthLabel";
            this.timeLengthLabel.Size = new System.Drawing.Size(109, 20);
            this.timeLengthLabel.TabIndex = 0;
            this.timeLengthLabel.Text = "運動時長：";
            // 
            // calorieText
            // 
            this.calorieText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.calorieText.Location = new System.Drawing.Point(118, 86);
            this.calorieText.Name = "calorieText";
            this.calorieText.Size = new System.Drawing.Size(181, 31);
            this.calorieText.TabIndex = 3;
            this.calorieText.TextChanged += new System.EventHandler(this.calorieText_TextChanged);
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.calorieLabel.Location = new System.Drawing.Point(3, 89);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(109, 20);
            this.calorieLabel.TabIndex = 0;
            this.calorieLabel.Text = "消耗熱量：";
            // 
            // kcalLabel
            // 
            this.kcalLabel.AutoSize = true;
            this.kcalLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.kcalLabel.Location = new System.Drawing.Point(305, 89);
            this.kcalLabel.Name = "kcalLabel";
            this.kcalLabel.Size = new System.Drawing.Size(49, 20);
            this.kcalLabel.TabIndex = 0;
            this.kcalLabel.Text = "大卡";
            // 
            // detailText
            // 
            this.detailText.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.detailText.Location = new System.Drawing.Point(7, 157);
            this.detailText.Multiline = true;
            this.detailText.Name = "detailText";
            this.detailText.Size = new System.Drawing.Size(402, 229);
            this.detailText.TabIndex = 4;
            this.detailText.TextChanged += new System.EventHandler(this.detailText_TextChanged);
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.detailLabel.Location = new System.Drawing.Point(3, 128);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(109, 20);
            this.detailLabel.TabIndex = 0;
            this.detailLabel.Text = "詳細內容：";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.minuteLabel.Location = new System.Drawing.Point(305, 48);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(49, 20);
            this.minuteLabel.TabIndex = 0;
            this.minuteLabel.Text = "分鐘";
            // 
            // ExercisePanel
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.timeLengthLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.timeLengthText);
            this.Controls.Add(this.kcalLabel);
            this.Controls.Add(this.detailText);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.calorieText);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ExercisePanel";
            this.Size = new System.Drawing.Size(414, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox calorieText;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.TextBox detailText;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label kcalLabel;
        private System.Windows.Forms.TextBox timeLengthText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label timeLengthLabel;
        private System.Windows.Forms.Label minuteLabel;
    }
}
