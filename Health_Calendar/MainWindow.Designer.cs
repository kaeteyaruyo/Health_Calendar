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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.calendarTabControl = new System.Windows.Forms.TabControl();
            this.calendarPage = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.recordViewPage = new System.Windows.Forms.TabPage();
            this.recordViewPanel = new System.Windows.Forms.Panel();
            this.editViewButton = new System.Windows.Forms.Button();
            this.backViewButton = new System.Windows.Forms.Button();
            this.BMIViewLabel = new System.Windows.Forms.Label();
            this.targetViewLabel = new System.Windows.Forms.Label();
            this.waistlineViewLabel = new System.Windows.Forms.Label();
            this.DBPViewLabel = new System.Windows.Forms.Label();
            this.SBPViewLabel = new System.Windows.Forms.Label();
            this.dateViewLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.weightViewLabel = new System.Windows.Forms.Label();
            this.recordEditPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addDietRecordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelRecordButton = new System.Windows.Forms.Button();
            this.exerciseCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateRecordButton = new System.Windows.Forms.Button();
            this.cmLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.waistlineEditText = new System.Windows.Forms.TextBox();
            this.weightEditText = new System.Windows.Forms.TextBox();
            this.addDietButton = new System.Windows.Forms.Button();
            this.recordEditDietLabel = new System.Windows.Forms.Label();
            this.DBPEditText = new System.Windows.Forms.TextBox();
            this.SBPEditText = new System.Windows.Forms.TextBox();
            this.dateEditLabel = new System.Windows.Forms.Label();
            this.recordEditTitleLabel = new System.Windows.Forms.Label();
            this.recordEditExerciseLabel = new System.Windows.Forms.Label();
            this.waistlineEditLabel = new System.Windows.Forms.Label();
            this.DBPEditLabel = new System.Windows.Forms.Label();
            this.weightEditLabel = new System.Windows.Forms.Label();
            this.SBPEditLabel = new System.Windows.Forms.Label();
            this.summaryPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.CheckSettingbutton = new System.Windows.Forms.Button();
            this.NoradioButton = new System.Windows.Forms.RadioButton();
            this.YesradioButton = new System.Windows.Forms.RadioButton();
            this.addSettingExerciseButton = new System.Windows.Forms.Button();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.settingExerciseTitleLabel = new System.Windows.Forms.Label();
            this.PermissionPanel = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.MinuteSetCombo = new System.Windows.Forms.ComboBox();
            this.HourSetCombo = new System.Windows.Forms.ComboBox();
            this.TimeSetLabel = new System.Windows.Forms.Label();
            this.OlderText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.StartDateCombo = new System.Windows.Forms.ComboBox();
            this.PermissionLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.OlderLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.settingPageTitleLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.calendarTabControl.SuspendLayout();
            this.calendarPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.recordViewPage.SuspendLayout();
            this.recordViewPanel.SuspendLayout();
            this.recordEditPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.PermissionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.mainPage);
            this.mainTabControl.Controls.Add(this.summaryPage);
            this.mainTabControl.Controls.Add(this.settingsPage);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Location = new System.Drawing.Point(65, 49);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1025, 469);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.calendarTabControl);
            this.mainPage.Location = new System.Drawing.Point(28, 4);
            this.mainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPage.Size = new System.Drawing.Size(993, 461);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "月曆";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // calendarTabControl
            // 
            this.calendarTabControl.Controls.Add(this.calendarPage);
            this.calendarTabControl.Controls.Add(this.recordViewPage);
            this.calendarTabControl.Controls.Add(this.recordEditPage);
            this.calendarTabControl.Location = new System.Drawing.Point(6, 12);
            this.calendarTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarTabControl.Name = "calendarTabControl";
            this.calendarTabControl.SelectedIndex = 0;
            this.calendarTabControl.Size = new System.Drawing.Size(984, 446);
            this.calendarTabControl.TabIndex = 0;
            // 
            // calendarPage
            // 
            this.calendarPage.BackgroundImage = global::Health_Calendar.Properties.Resources.b7;
            this.calendarPage.Controls.Add(this.panel8);
            this.calendarPage.Controls.Add(this.label57);
            this.calendarPage.Location = new System.Drawing.Point(4, 28);
            this.calendarPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarPage.Name = "calendarPage";
            this.calendarPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarPage.Size = new System.Drawing.Size(976, 414);
            this.calendarPage.TabIndex = 2;
            this.calendarPage.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label52);
            this.panel8.Controls.Add(this.label53);
            this.panel8.Controls.Add(this.label54);
            this.panel8.Controls.Add(this.label55);
            this.panel8.Controls.Add(this.label56);
            this.panel8.Controls.Add(this.label51);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(840, 59);
            this.panel8.TabIndex = 0;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label52.Location = new System.Drawing.Point(757, 16);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(80, 40);
            this.label52.TabIndex = 2;
            this.label52.Text = "FRI";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label53.Location = new System.Drawing.Point(622, 16);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(80, 40);
            this.label53.TabIndex = 3;
            this.label53.Text = "THU";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label54.Location = new System.Drawing.Point(493, 16);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(80, 40);
            this.label54.TabIndex = 4;
            this.label54.Text = "WED";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label55.Location = new System.Drawing.Point(357, 16);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(80, 40);
            this.label55.TabIndex = 5;
            this.label55.Text = "TUE";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label56.Location = new System.Drawing.Point(226, 16);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 40);
            this.label56.TabIndex = 6;
            this.label56.Text = "MON";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label51.Location = new System.Drawing.Point(90, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(80, 40);
            this.label51.TabIndex = 1;
            this.label51.Text = "SUN";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("華康竹風體W4", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label57.Location = new System.Drawing.Point(890, 22);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(80, 40);
            this.label57.TabIndex = 3;
            this.label57.Text = "SAT";
            // 
            // recordViewPage
            // 
            this.recordViewPage.AutoScroll = true;
            this.recordViewPage.BackgroundImage = global::Health_Calendar.Properties.Resources.date4;
            this.recordViewPage.Controls.Add(this.recordViewPanel);
            this.recordViewPage.Location = new System.Drawing.Point(4, 28);
            this.recordViewPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPage.Name = "recordViewPage";
            this.recordViewPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPage.Size = new System.Drawing.Size(976, 414);
            this.recordViewPage.TabIndex = 1;
            this.recordViewPage.UseVisualStyleBackColor = true;
            this.recordViewPage.Enter += new System.EventHandler(this.recordViewPage_Enter);
            this.recordViewPage.Leave += new System.EventHandler(this.recordViewPage_Leave);
            // 
            // recordViewPanel
            // 
            this.recordViewPanel.AutoScroll = true;
            this.recordViewPanel.Controls.Add(this.editViewButton);
            this.recordViewPanel.Controls.Add(this.backViewButton);
            this.recordViewPanel.Controls.Add(this.BMIViewLabel);
            this.recordViewPanel.Controls.Add(this.targetViewLabel);
            this.recordViewPanel.Controls.Add(this.waistlineViewLabel);
            this.recordViewPanel.Controls.Add(this.DBPViewLabel);
            this.recordViewPanel.Controls.Add(this.SBPViewLabel);
            this.recordViewPanel.Controls.Add(this.dateViewLabel);
            this.recordViewPanel.Controls.Add(this.label19);
            this.recordViewPanel.Controls.Add(this.weightViewLabel);
            this.recordViewPanel.Location = new System.Drawing.Point(41, 36);
            this.recordViewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPanel.Name = "recordViewPanel";
            this.recordViewPanel.Size = new System.Drawing.Size(810, 574);
            this.recordViewPanel.TabIndex = 1;
            // 
            // editViewButton
            // 
            this.editViewButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editViewButton.Location = new System.Drawing.Point(665, 15);
            this.editViewButton.Name = "editViewButton";
            this.editViewButton.Size = new System.Drawing.Size(120, 49);
            this.editViewButton.TabIndex = 15;
            this.editViewButton.Text = "修改";
            this.editViewButton.UseVisualStyleBackColor = true;
            this.editViewButton.Click += new System.EventHandler(this.editViewButton_Click);
            // 
            // backViewButton
            // 
            this.backViewButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backViewButton.Location = new System.Drawing.Point(548, 15);
            this.backViewButton.Name = "backViewButton";
            this.backViewButton.Size = new System.Drawing.Size(111, 49);
            this.backViewButton.TabIndex = 14;
            this.backViewButton.Text = "返回";
            this.backViewButton.UseVisualStyleBackColor = true;
            this.backViewButton.Click += new System.EventHandler(this.backViewButton_Click);
            // 
            // BMIViewLabel
            // 
            this.BMIViewLabel.AutoSize = true;
            this.BMIViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.BMIViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BMIViewLabel.Location = new System.Drawing.Point(56, 148);
            this.BMIViewLabel.Name = "BMIViewLabel";
            this.BMIViewLabel.Size = new System.Drawing.Size(424, 40);
            this.BMIViewLabel.TabIndex = 13;
            this.BMIViewLabel.Text = "BMI:XX  (標準/過胖/過瘦)";
            // 
            // targetViewLabel
            // 
            this.targetViewLabel.AutoSize = true;
            this.targetViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.targetViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.targetViewLabel.Location = new System.Drawing.Point(412, 83);
            this.targetViewLabel.Name = "targetViewLabel";
            this.targetViewLabel.Size = new System.Drawing.Size(334, 40);
            this.targetViewLabel.TabIndex = 8;
            this.targetViewLabel.Text = "離目標還有XX kg喔!";
            // 
            // waistlineViewLabel
            // 
            this.waistlineViewLabel.AutoSize = true;
            this.waistlineViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineViewLabel.Location = new System.Drawing.Point(64, 320);
            this.waistlineViewLabel.Name = "waistlineViewLabel";
            this.waistlineViewLabel.Size = new System.Drawing.Size(305, 40);
            this.waistlineViewLabel.TabIndex = 7;
            this.waistlineViewLabel.Text = "腰圍:             cm";
            // 
            // DBPViewLabel
            // 
            this.DBPViewLabel.AutoSize = true;
            this.DBPViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPViewLabel.Location = new System.Drawing.Point(56, 270);
            this.DBPViewLabel.Name = "DBPViewLabel";
            this.DBPViewLabel.Size = new System.Drawing.Size(144, 40);
            this.DBPViewLabel.TabIndex = 6;
            this.DBPViewLabel.Text = "舒張壓:";
            // 
            // SBPViewLabel
            // 
            this.SBPViewLabel.AutoSize = true;
            this.SBPViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPViewLabel.Location = new System.Drawing.Point(56, 210);
            this.SBPViewLabel.Name = "SBPViewLabel";
            this.SBPViewLabel.Size = new System.Drawing.Size(144, 40);
            this.SBPViewLabel.TabIndex = 5;
            this.SBPViewLabel.Text = "收縮壓:";
            // 
            // dateViewLabel
            // 
            this.dateViewLabel.AutoSize = true;
            this.dateViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateViewLabel.Location = new System.Drawing.Point(64, 15);
            this.dateViewLabel.Name = "dateViewLabel";
            this.dateViewLabel.Size = new System.Drawing.Size(127, 40);
            this.dateViewLabel.TabIndex = 3;
            this.dateViewLabel.Text = " 月 日";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 18);
            this.label19.TabIndex = 1;
            // 
            // weightViewLabel
            // 
            this.weightViewLabel.AutoSize = true;
            this.weightViewLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightViewLabel.Location = new System.Drawing.Point(56, 83);
            this.weightViewLabel.Name = "weightViewLabel";
            this.weightViewLabel.Size = new System.Drawing.Size(311, 40);
            this.weightViewLabel.TabIndex = 0;
            this.weightViewLabel.Text = "體重:              kg";
            // 
            // recordEditPage
            // 
            this.recordEditPage.AutoScroll = true;
            this.recordEditPage.BackgroundImage = global::Health_Calendar.Properties.Resources.b3;
            this.recordEditPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordEditPage.Controls.Add(this.panel1);
            this.recordEditPage.Location = new System.Drawing.Point(4, 28);
            this.recordEditPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordEditPage.Name = "recordEditPage";
            this.recordEditPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordEditPage.Size = new System.Drawing.Size(976, 414);
            this.recordEditPage.TabIndex = 0;
            this.recordEditPage.UseVisualStyleBackColor = true;
            this.recordEditPage.Enter += new System.EventHandler(this.recordEditPage_Enter);
            this.recordEditPage.Leave += new System.EventHandler(this.recordEditPage_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.addDietRecordButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelRecordButton);
            this.panel1.Controls.Add(this.exerciseCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updateRecordButton);
            this.panel1.Controls.Add(this.cmLabel);
            this.panel1.Controls.Add(this.kgLabel);
            this.panel1.Controls.Add(this.waistlineEditText);
            this.panel1.Controls.Add(this.weightEditText);
            this.panel1.Controls.Add(this.addDietButton);
            this.panel1.Controls.Add(this.recordEditDietLabel);
            this.panel1.Controls.Add(this.DBPEditText);
            this.panel1.Controls.Add(this.SBPEditText);
            this.panel1.Controls.Add(this.dateEditLabel);
            this.panel1.Controls.Add(this.recordEditTitleLabel);
            this.panel1.Controls.Add(this.recordEditExerciseLabel);
            this.panel1.Controls.Add(this.waistlineEditLabel);
            this.panel1.Controls.Add(this.DBPEditLabel);
            this.panel1.Controls.Add(this.weightEditLabel);
            this.panel1.Controls.Add(this.SBPEditLabel);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 798);
            this.panel1.TabIndex = 14;
            // 
            // addDietRecordButton
            // 
            this.addDietRecordButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addDietRecordButton.Location = new System.Drawing.Point(290, 608);
            this.addDietRecordButton.Name = "addDietRecordButton";
            this.addDietRecordButton.Size = new System.Drawing.Size(101, 41);
            this.addDietRecordButton.TabIndex = 28;
            this.addDietRecordButton.Text = "新增";
            this.addDietRecordButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(438, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "mmHg";
            // 
            // cancelRecordButton
            // 
            this.cancelRecordButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancelRecordButton.Location = new System.Drawing.Point(796, 12);
            this.cancelRecordButton.Name = "cancelRecordButton";
            this.cancelRecordButton.Size = new System.Drawing.Size(103, 43);
            this.cancelRecordButton.TabIndex = 16;
            this.cancelRecordButton.Text = "取消";
            this.cancelRecordButton.UseVisualStyleBackColor = true;
            this.cancelRecordButton.Click += new System.EventHandler(this.cancelRecordButton_Click);
            // 
            // exerciseCheckBox
            // 
            this.exerciseCheckBox.FormattingEnabled = true;
            this.exerciseCheckBox.Location = new System.Drawing.Point(83, 433);
            this.exerciseCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exerciseCheckBox.Name = "exerciseCheckBox";
            this.exerciseCheckBox.Size = new System.Drawing.Size(530, 148);
            this.exerciseCheckBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(438, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "mmHg";
            // 
            // updateRecordButton
            // 
            this.updateRecordButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateRecordButton.Location = new System.Drawing.Point(595, 13);
            this.updateRecordButton.Name = "updateRecordButton";
            this.updateRecordButton.Size = new System.Drawing.Size(186, 42);
            this.updateRecordButton.TabIndex = 15;
            this.updateRecordButton.Text = "確認修改";
            this.updateRecordButton.UseVisualStyleBackColor = true;
            this.updateRecordButton.Click += new System.EventHandler(this.updateRecordButton_Click);
            // 
            // cmLabel
            // 
            this.cmLabel.AutoSize = true;
            this.cmLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmLabel.Location = new System.Drawing.Point(366, 305);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(43, 32);
            this.cmLabel.TabIndex = 25;
            this.cmLabel.Text = "cm";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kgLabel.Location = new System.Drawing.Point(353, 144);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(38, 36);
            this.kgLabel.TabIndex = 24;
            this.kgLabel.Text = "kg";
            // 
            // waistlineEditText
            // 
            this.waistlineEditText.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditText.Location = new System.Drawing.Point(268, 299);
            this.waistlineEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waistlineEditText.Name = "waistlineEditText";
            this.waistlineEditText.Size = new System.Drawing.Size(82, 39);
            this.waistlineEditText.TabIndex = 23;
            // 
            // weightEditText
            // 
            this.weightEditText.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditText.Location = new System.Drawing.Point(274, 137);
            this.weightEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightEditText.Name = "weightEditText";
            this.weightEditText.Size = new System.Drawing.Size(61, 39);
            this.weightEditText.TabIndex = 22;
            // 
            // addDietButton
            // 
            this.addDietButton.Location = new System.Drawing.Point(134, 499);
            this.addDietButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDietButton.Name = "addDietButton";
            this.addDietButton.Size = new System.Drawing.Size(75, 31);
            this.addDietButton.TabIndex = 18;
            this.addDietButton.Text = "新增";
            this.addDietButton.UseVisualStyleBackColor = true;
            // 
            // recordEditDietLabel
            // 
            this.recordEditDietLabel.AutoSize = true;
            this.recordEditDietLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditDietLabel.Location = new System.Drawing.Point(58, 608);
            this.recordEditDietLabel.Name = "recordEditDietLabel";
            this.recordEditDietLabel.Size = new System.Drawing.Size(225, 48);
            this.recordEditDietLabel.TabIndex = 16;
            this.recordEditDietLabel.Text = "今日飲食:";
            // 
            // DBPEditText
            // 
            this.DBPEditText.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditText.Location = new System.Drawing.Point(309, 250);
            this.DBPEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBPEditText.Name = "DBPEditText";
            this.DBPEditText.Size = new System.Drawing.Size(100, 39);
            this.DBPEditText.TabIndex = 15;
            // 
            // SBPEditText
            // 
            this.SBPEditText.Font = new System.Drawing.Font("華康秀風體W3(P)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditText.Location = new System.Drawing.Point(309, 196);
            this.SBPEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SBPEditText.Name = "SBPEditText";
            this.SBPEditText.Size = new System.Drawing.Size(100, 39);
            this.SBPEditText.TabIndex = 14;
            // 
            // dateEditLabel
            // 
            this.dateEditLabel.AutoSize = true;
            this.dateEditLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateEditLabel.Location = new System.Drawing.Point(17, 12);
            this.dateEditLabel.Name = "dateEditLabel";
            this.dateEditLabel.Size = new System.Drawing.Size(176, 56);
            this.dateEditLabel.TabIndex = 0;
            this.dateEditLabel.Text = "x年x日";
            // 
            // recordEditTitleLabel
            // 
            this.recordEditTitleLabel.AutoSize = true;
            this.recordEditTitleLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditTitleLabel.Location = new System.Drawing.Point(47, 77);
            this.recordEditTitleLabel.Name = "recordEditTitleLabel";
            this.recordEditTitleLabel.Size = new System.Drawing.Size(225, 48);
            this.recordEditTitleLabel.TabIndex = 2;
            this.recordEditTitleLabel.Text = "今日紀錄:";
            // 
            // recordEditExerciseLabel
            // 
            this.recordEditExerciseLabel.AutoSize = true;
            this.recordEditExerciseLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditExerciseLabel.Location = new System.Drawing.Point(58, 367);
            this.recordEditExerciseLabel.Name = "recordEditExerciseLabel";
            this.recordEditExerciseLabel.Size = new System.Drawing.Size(225, 48);
            this.recordEditExerciseLabel.TabIndex = 3;
            this.recordEditExerciseLabel.Text = "今日運動:";
            // 
            // waistlineEditLabel
            // 
            this.waistlineEditLabel.AutoSize = true;
            this.waistlineEditLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditLabel.Location = new System.Drawing.Point(155, 299);
            this.waistlineEditLabel.Name = "waistlineEditLabel";
            this.waistlineEditLabel.Size = new System.Drawing.Size(107, 40);
            this.waistlineEditLabel.TabIndex = 9;
            this.waistlineEditLabel.Text = "腰圍:";
            // 
            // DBPEditLabel
            // 
            this.DBPEditLabel.AutoSize = true;
            this.DBPEditLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditLabel.Location = new System.Drawing.Point(155, 247);
            this.DBPEditLabel.Name = "DBPEditLabel";
            this.DBPEditLabel.Size = new System.Drawing.Size(148, 40);
            this.DBPEditLabel.TabIndex = 11;
            this.DBPEditLabel.Text = "舒張壓:";
            // 
            // weightEditLabel
            // 
            this.weightEditLabel.AutoSize = true;
            this.weightEditLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditLabel.Location = new System.Drawing.Point(155, 140);
            this.weightEditLabel.Name = "weightEditLabel";
            this.weightEditLabel.Size = new System.Drawing.Size(107, 40);
            this.weightEditLabel.TabIndex = 7;
            this.weightEditLabel.Text = "體重:";
            // 
            // SBPEditLabel
            // 
            this.SBPEditLabel.AutoSize = true;
            this.SBPEditLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditLabel.Location = new System.Drawing.Point(155, 199);
            this.SBPEditLabel.Name = "SBPEditLabel";
            this.SBPEditLabel.Size = new System.Drawing.Size(148, 40);
            this.SBPEditLabel.TabIndex = 10;
            this.SBPEditLabel.Text = "收縮壓:";
            // 
            // summaryPage
            // 
            this.summaryPage.Location = new System.Drawing.Point(28, 4);
            this.summaryPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryPage.Name = "summaryPage";
            this.summaryPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryPage.Size = new System.Drawing.Size(993, 461);
            this.summaryPage.TabIndex = 1;
            this.summaryPage.Text = "統計";
            this.summaryPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.AutoScroll = true;
            this.settingsPage.BackgroundImage = global::Health_Calendar.Properties.Resources.b2;
            this.settingsPage.Controls.Add(this.settingPanel);
            this.settingsPage.Location = new System.Drawing.Point(28, 4);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(993, 461);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "設定";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // settingPanel
            // 
            this.settingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingPanel.Controls.Add(this.settingPageTitleLabel);
            this.settingPanel.Controls.Add(this.CheckSettingbutton);
            this.settingPanel.Controls.Add(this.NoradioButton);
            this.settingPanel.Controls.Add(this.YesradioButton);
            this.settingPanel.Controls.Add(this.addSettingExerciseButton);
            this.settingPanel.Controls.Add(this.StartDateLabel);
            this.settingPanel.Controls.Add(this.settingExerciseTitleLabel);
            this.settingPanel.Controls.Add(this.PermissionPanel);
            this.settingPanel.Controls.Add(this.OlderText);
            this.settingPanel.Controls.Add(this.HeightText);
            this.settingPanel.Controls.Add(this.StartDateCombo);
            this.settingPanel.Controls.Add(this.PermissionLabel);
            this.settingPanel.Controls.Add(this.yearLabel);
            this.settingPanel.Controls.Add(this.mLabel);
            this.settingPanel.Controls.Add(this.OlderLabel);
            this.settingPanel.Controls.Add(this.HeightLabel);
            this.settingPanel.Location = new System.Drawing.Point(19, 24);
            this.settingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(859, 732);
            this.settingPanel.TabIndex = 1;
            // 
            // CheckSettingbutton
            // 
            this.CheckSettingbutton.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckSettingbutton.Location = new System.Drawing.Point(717, 650);
            this.CheckSettingbutton.Name = "CheckSettingbutton";
            this.CheckSettingbutton.Size = new System.Drawing.Size(119, 62);
            this.CheckSettingbutton.TabIndex = 18;
            this.CheckSettingbutton.Text = "確認";
            this.CheckSettingbutton.UseVisualStyleBackColor = true;
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoradioButton.Location = new System.Drawing.Point(427, 337);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(82, 48);
            this.NoradioButton.TabIndex = 17;
            this.NoradioButton.TabStop = true;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            // 
            // YesradioButton
            // 
            this.YesradioButton.AutoSize = true;
            this.YesradioButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YesradioButton.Location = new System.Drawing.Point(287, 337);
            this.YesradioButton.Name = "YesradioButton";
            this.YesradioButton.Size = new System.Drawing.Size(96, 48);
            this.YesradioButton.TabIndex = 16;
            this.YesradioButton.TabStop = true;
            this.YesradioButton.Text = "Yes";
            this.YesradioButton.UseVisualStyleBackColor = true;
            // 
            // addSettingExerciseButton
            // 
            this.addSettingExerciseButton.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSettingExerciseButton.Location = new System.Drawing.Point(412, 517);
            this.addSettingExerciseButton.Name = "addSettingExerciseButton";
            this.addSettingExerciseButton.Size = new System.Drawing.Size(128, 43);
            this.addSettingExerciseButton.TabIndex = 15;
            this.addSettingExerciseButton.Text = "新增";
            this.addSettingExerciseButton.UseVisualStyleBackColor = true;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateLabel.Location = new System.Drawing.Point(123, 51);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(319, 56);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "起始日設定:";
            // 
            // settingExerciseTitleLabel
            // 
            this.settingExerciseTitleLabel.AutoSize = true;
            this.settingExerciseTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingExerciseTitleLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingExerciseTitleLabel.Location = new System.Drawing.Point(134, 505);
            this.settingExerciseTitleLabel.Name = "settingExerciseTitleLabel";
            this.settingExerciseTitleLabel.Size = new System.Drawing.Size(262, 56);
            this.settingExerciseTitleLabel.TabIndex = 14;
            this.settingExerciseTitleLabel.Text = "運動項目:";
            // 
            // PermissionPanel
            // 
            this.PermissionPanel.BackColor = System.Drawing.Color.Transparent;
            this.PermissionPanel.Controls.Add(this.label39);
            this.PermissionPanel.Controls.Add(this.MinuteSetCombo);
            this.PermissionPanel.Controls.Add(this.HourSetCombo);
            this.PermissionPanel.Controls.Add(this.TimeSetLabel);
            this.PermissionPanel.Location = new System.Drawing.Point(252, 390);
            this.PermissionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermissionPanel.Name = "PermissionPanel";
            this.PermissionPanel.Size = new System.Drawing.Size(406, 76);
            this.PermissionPanel.TabIndex = 11;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("華康秀風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Location = new System.Drawing.Point(279, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(25, 40);
            this.label39.TabIndex = 12;
            this.label39.Text = ":";
            // 
            // MinuteSetCombo
            // 
            this.MinuteSetCombo.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteSetCombo.FormattingEnabled = true;
            this.MinuteSetCombo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinuteSetCombo.Location = new System.Drawing.Point(310, 13);
            this.MinuteSetCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinuteSetCombo.Name = "MinuteSetCombo";
            this.MinuteSetCombo.Size = new System.Drawing.Size(72, 44);
            this.MinuteSetCombo.TabIndex = 2;
            // 
            // HourSetCombo
            // 
            this.HourSetCombo.Font = new System.Drawing.Font("華康秀風體W3(P)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourSetCombo.FormattingEnabled = true;
            this.HourSetCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.HourSetCombo.Location = new System.Drawing.Point(203, 13);
            this.HourSetCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourSetCombo.Name = "HourSetCombo";
            this.HourSetCombo.Size = new System.Drawing.Size(70, 44);
            this.HourSetCombo.TabIndex = 1;
            // 
            // TimeSetLabel
            // 
            this.TimeSetLabel.AutoSize = true;
            this.TimeSetLabel.Font = new System.Drawing.Font("華康兒風體W3(P)", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeSetLabel.Location = new System.Drawing.Point(7, 17);
            this.TimeSetLabel.Name = "TimeSetLabel";
            this.TimeSetLabel.Size = new System.Drawing.Size(188, 40);
            this.TimeSetLabel.TabIndex = 0;
            this.TimeSetLabel.Text = "提醒時間:";
            // 
            // OlderText
            // 
            this.OlderText.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OlderText.Location = new System.Drawing.Point(292, 196);
            this.OlderText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OlderText.Name = "OlderText";
            this.OlderText.Size = new System.Drawing.Size(100, 55);
            this.OlderText.TabIndex = 8;
            // 
            // HeightText
            // 
            this.HeightText.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightText.Location = new System.Drawing.Point(292, 121);
            this.HeightText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(100, 55);
            this.HeightText.TabIndex = 7;
            // 
            // StartDateCombo
            // 
            this.StartDateCombo.Font = new System.Drawing.Font("華康秀風體W3(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateCombo.FormattingEnabled = true;
            this.StartDateCombo.Location = new System.Drawing.Point(479, 51);
            this.StartDateCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDateCombo.Name = "StartDateCombo";
            this.StartDateCombo.Size = new System.Drawing.Size(77, 56);
            this.StartDateCombo.TabIndex = 6;
            // 
            // PermissionLabel
            // 
            this.PermissionLabel.AutoSize = true;
            this.PermissionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PermissionLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PermissionLabel.Location = new System.Drawing.Point(134, 266);
            this.PermissionLabel.Name = "PermissionLabel";
            this.PermissionLabel.Size = new System.Drawing.Size(500, 56);
            this.PermissionLabel.TabIndex = 5;
            this.PermissionLabel.Text = "是否發出推播通知?";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearLabel.Location = new System.Drawing.Point(420, 204);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(65, 44);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "歲";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.BackColor = System.Drawing.Color.Transparent;
            this.mLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mLabel.Location = new System.Drawing.Point(431, 133);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(41, 44);
            this.mLabel.TabIndex = 3;
            this.mLabel.Text = "m";
            // 
            // OlderLabel
            // 
            this.OlderLabel.AutoSize = true;
            this.OlderLabel.BackColor = System.Drawing.Color.Transparent;
            this.OlderLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OlderLabel.Location = new System.Drawing.Point(123, 192);
            this.OlderLabel.Name = "OlderLabel";
            this.OlderLabel.Size = new System.Drawing.Size(148, 56);
            this.OlderLabel.TabIndex = 2;
            this.OlderLabel.Text = "年齡:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightLabel.Location = new System.Drawing.Point(123, 121);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(148, 56);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "身高:";
            // 
            // settingPageTitleLabel
            // 
            this.settingPageTitleLabel.AutoSize = true;
            this.settingPageTitleLabel.Font = new System.Drawing.Font("華康秀風體W3(P)", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingPageTitleLabel.Location = new System.Drawing.Point(15, 7);
            this.settingPageTitleLabel.Name = "settingPageTitleLabel";
            this.settingPageTitleLabel.Size = new System.Drawing.Size(208, 44);
            this.settingPageTitleLabel.TabIndex = 19;
            this.settingPageTitleLabel.Text = "基本設定:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 842);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Health_Calendar";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainTabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.calendarTabControl.ResumeLayout(false);
            this.calendarPage.ResumeLayout(false);
            this.calendarPage.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.recordViewPage.ResumeLayout(false);
            this.recordViewPanel.ResumeLayout(false);
            this.recordViewPanel.PerformLayout();
            this.recordEditPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.PermissionPanel.ResumeLayout(false);
            this.PermissionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage summaryPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TabControl calendarTabControl;
        private System.Windows.Forms.TabPage recordViewPage;
        private System.Windows.Forms.TabPage recordEditPage;
        private System.Windows.Forms.Panel recordViewPanel;
        private System.Windows.Forms.Label BMIViewLabel;
        private System.Windows.Forms.Label targetViewLabel;
        private System.Windows.Forms.Label waistlineViewLabel;
        private System.Windows.Forms.Label DBPViewLabel;
        private System.Windows.Forms.Label SBPViewLabel;
        private System.Windows.Forms.Label dateViewLabel;
        private System.Windows.Forms.Label weightViewLabel;
        private System.Windows.Forms.TabPage calendarPage;
        private System.Windows.Forms.Label dateEditLabel;
        private System.Windows.Forms.Label waistlineEditLabel;
        private System.Windows.Forms.Label weightEditLabel;
        private System.Windows.Forms.Label recordEditExerciseLabel;
        private System.Windows.Forms.Label recordEditTitleLabel;
        private System.Windows.Forms.CheckedListBox exerciseCheckBox;
        private System.Windows.Forms.Label DBPEditLabel;
        private System.Windows.Forms.Label SBPEditLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cmLabel;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.TextBox waistlineEditText;
        private System.Windows.Forms.TextBox weightEditText;
        private System.Windows.Forms.Button addDietButton;
        private System.Windows.Forms.Label recordEditDietLabel;
        private System.Windows.Forms.TextBox DBPEditText;
        private System.Windows.Forms.TextBox SBPEditText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Panel PermissionPanel;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox MinuteSetCombo;
        private System.Windows.Forms.ComboBox HourSetCombo;
        private System.Windows.Forms.Label TimeSetLabel;
        private System.Windows.Forms.TextBox OlderText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.ComboBox StartDateCombo;
        private System.Windows.Forms.Label PermissionLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label OlderLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label settingExerciseTitleLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button addSettingExerciseButton;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.RadioButton YesradioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CheckSettingbutton;
        private System.Windows.Forms.Button updateRecordButton;
        private System.Windows.Forms.Button cancelRecordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editViewButton;
        private System.Windows.Forms.Button backViewButton;
        private System.Windows.Forms.Button addDietRecordButton;
        private System.Windows.Forms.Label settingPageTitleLabel;
    }
}

