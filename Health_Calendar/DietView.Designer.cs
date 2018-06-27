namespace Health_Calendar
{
    partial class DietView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mealViewLabel = new System.Windows.Forms.Label();
            this.calorieViewLabel = new System.Windows.Forms.Label();
            this.detailViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mealViewLabel
            // 
            this.mealViewLabel.AutoSize = true;
            this.mealViewLabel.Location = new System.Drawing.Point(37, 30);
            this.mealViewLabel.Name = "mealViewLabel";
            this.mealViewLabel.Size = new System.Drawing.Size(42, 18);
            this.mealViewLabel.TabIndex = 0;
            this.mealViewLabel.Text = "meal";
            // 
            // calorieViewLabel
            // 
            this.calorieViewLabel.AutoSize = true;
            this.calorieViewLabel.Location = new System.Drawing.Point(37, 78);
            this.calorieViewLabel.Name = "calorieViewLabel";
            this.calorieViewLabel.Size = new System.Drawing.Size(85, 18);
            this.calorieViewLabel.TabIndex = 1;
            this.calorieViewLabel.Text = "攝取熱量:";
            // 
            // detailViewLabel
            // 
            this.detailViewLabel.AutoSize = true;
            this.detailViewLabel.Location = new System.Drawing.Point(37, 116);
            this.detailViewLabel.Name = "detailViewLabel";
            this.detailViewLabel.Size = new System.Drawing.Size(49, 18);
            this.detailViewLabel.TabIndex = 2;
            this.detailViewLabel.Text = "內容:";
            // 
            // DietView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailViewLabel);
            this.Controls.Add(this.calorieViewLabel);
            this.Controls.Add(this.mealViewLabel);
            this.Name = "DietView";
            this.Size = new System.Drawing.Size(356, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealViewLabel;
        private System.Windows.Forms.Label calorieViewLabel;
        private System.Windows.Forms.Label detailViewLabel;
    }
}
