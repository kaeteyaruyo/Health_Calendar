namespace Health_Calendar
{
    partial class ExerciseViewPanel
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
            this.titleViewLabel = new System.Windows.Forms.Label();
            this.TimeLengthLabel = new System.Windows.Forms.Label();
            this.detailViewLabel = new System.Windows.Forms.Label();
            this.kcalViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleViewLabel
            // 
            this.titleViewLabel.AutoSize = true;
            this.titleViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleViewLabel.Location = new System.Drawing.Point(2, 13);
            this.titleViewLabel.Name = "titleViewLabel";
            this.titleViewLabel.Size = new System.Drawing.Size(104, 40);
            this.titleViewLabel.TabIndex = 0;
            this.titleViewLabel.Text = "項目:";
            // 
            // TimeLengthLabel
            // 
            this.TimeLengthLabel.AutoSize = true;
            this.TimeLengthLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeLengthLabel.Location = new System.Drawing.Point(3, 53);
            this.TimeLengthLabel.Name = "TimeLengthLabel";
            this.TimeLengthLabel.Size = new System.Drawing.Size(84, 32);
            this.TimeLengthLabel.TabIndex = 1;
            this.TimeLengthLabel.Text = "時長:";
            // 
            // detailViewLabel
            // 
            this.detailViewLabel.AutoSize = true;
            this.detailViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.detailViewLabel.Location = new System.Drawing.Point(3, 117);
            this.detailViewLabel.Name = "detailViewLabel";
            this.detailViewLabel.Size = new System.Drawing.Size(84, 32);
            this.detailViewLabel.TabIndex = 2;
            this.detailViewLabel.Text = "內容:";
            // 
            // kcalViewLabel
            // 
            this.kcalViewLabel.AutoSize = true;
            this.kcalViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kcalViewLabel.Location = new System.Drawing.Point(3, 85);
            this.kcalViewLabel.Name = "kcalViewLabel";
            this.kcalViewLabel.Size = new System.Drawing.Size(180, 32);
            this.kcalViewLabel.TabIndex = 3;
            this.kcalViewLabel.Text = "消耗卡路里:";
            // 
            // ExerciseViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kcalViewLabel);
            this.Controls.Add(this.detailViewLabel);
            this.Controls.Add(this.TimeLengthLabel);
            this.Controls.Add(this.titleViewLabel);
            this.Name = "ExerciseViewPanel";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleViewLabel;
        private System.Windows.Forms.Label TimeLengthLabel;
        private System.Windows.Forms.Label detailViewLabel;
        private System.Windows.Forms.Label kcalViewLabel;
    }
}
