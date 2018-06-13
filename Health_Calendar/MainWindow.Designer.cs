namespace Health_Calendar
{
    partial class MainWindow
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
            this.settingTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.summaryTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.calendarPage = new System.Windows.Forms.TabPage();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.settingTab.SuspendLayout();
            this.summaryTab.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTab
            // 
            this.settingTab.Controls.Add(this.button3);
            this.settingTab.Location = new System.Drawing.Point(26, 4);
            this.settingTab.Name = "settingTab";
            this.settingTab.Size = new System.Drawing.Size(720, 442);
            this.settingTab.TabIndex = 2;
            this.settingTab.Text = "設定";
            this.settingTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // summaryTab
            // 
            this.summaryTab.Controls.Add(this.button2);
            this.summaryTab.Location = new System.Drawing.Point(26, 4);
            this.summaryTab.Margin = new System.Windows.Forms.Padding(0);
            this.summaryTab.Name = "summaryTab";
            this.summaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTab.Size = new System.Drawing.Size(720, 442);
            this.summaryTab.TabIndex = 1;
            this.summaryTab.Text = "統計";
            this.summaryTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // calendarPage
            // 
            this.calendarPage.Location = new System.Drawing.Point(26, 4);
            this.calendarPage.Name = "calendarPage";
            this.calendarPage.Padding = new System.Windows.Forms.Padding(3);
            this.calendarPage.Size = new System.Drawing.Size(720, 442);
            this.calendarPage.TabIndex = 0;
            this.calendarPage.Text = "月曆";
            this.calendarPage.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.calendarPage);
            this.mainTabControl.Controls.Add(this.summaryTab);
            this.mainTabControl.Controls.Add(this.settingTab);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Location = new System.Drawing.Point(12, 73);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(750, 450);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TabStop = false;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Health_Calendar";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.settingTab.ResumeLayout(false);
            this.summaryTab.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage settingTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage summaryTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage calendarPage;
        private System.Windows.Forms.TabControl mainTabControl;
    }
}

