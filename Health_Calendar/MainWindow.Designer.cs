using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.calendarTabControl = new System.Windows.Forms.TabControl();
            this.calendarPage = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.friLabel = new System.Windows.Forms.Label();
            this.theLabel = new System.Windows.Forms.Label();
            this.wedLabel = new System.Windows.Forms.Label();
            this.tueLabel = new System.Windows.Forms.Label();
            this.monLabel = new System.Windows.Forms.Label();
            this.sunLabel = new System.Windows.Forms.Label();
            this.satLabel = new System.Windows.Forms.Label();
            this.recordViewPage = new System.Windows.Forms.TabPage();
            this.recordViewPanel = new System.Windows.Forms.Panel();
            this.dtLabel = new System.Windows.Forms.Label();
            this.etLabel = new System.Windows.Forms.Label();
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
            this.editPanel = new System.Windows.Forms.Panel();
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
            this.thismonthLabel = new System.Windows.Forms.Label();
            this.nextmonthButton = new System.Windows.Forms.Button();
            this.lastmonthButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.summaryTitle = new System.Windows.Forms.Label();
            this.excriseChartbutton = new System.Windows.Forms.Button();
            this.caloriebutton = new System.Windows.Forms.Button();
            this.weightbutton = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingPageTitleLabel = new System.Windows.Forms.Label();
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
            this.HeightText = new System.Windows.Forms.TextBox();
            this.StartDateCombo = new System.Windows.Forms.ComboBox();
            this.PermissionLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainTabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.calendarTabControl.SuspendLayout();
            this.calendarPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.recordViewPage.SuspendLayout();
            this.recordViewPanel.SuspendLayout();
            this.recordEditPage.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.summaryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            this.mainTabControl.Location = new System.Drawing.Point(56, 71);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(911, 391);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.calendarTabControl);
            this.mainPage.Location = new System.Drawing.Point(26, 4);
            this.mainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPage.Size = new System.Drawing.Size(881, 383);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "月曆";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // calendarTabControl
            // 
            this.calendarTabControl.Controls.Add(this.calendarPage);
            this.calendarTabControl.Controls.Add(this.recordViewPage);
            this.calendarTabControl.Controls.Add(this.recordEditPage);
            this.calendarTabControl.Location = new System.Drawing.Point(5, 10);
            this.calendarTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarTabControl.Name = "calendarTabControl";
            this.calendarTabControl.SelectedIndex = 0;
            this.calendarTabControl.Size = new System.Drawing.Size(875, 372);
            this.calendarTabControl.TabIndex = 0;
            // 
            // calendarPage
            // 
            this.calendarPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarPage.BackgroundImage")));
            this.calendarPage.Controls.Add(this.panel8);
            this.calendarPage.Controls.Add(this.satLabel);
            this.calendarPage.Location = new System.Drawing.Point(4, 25);
            this.calendarPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarPage.Name = "calendarPage";
            this.calendarPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarPage.Size = new System.Drawing.Size(867, 343);
            this.calendarPage.TabIndex = 2;
            this.calendarPage.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.friLabel);
            this.panel8.Controls.Add(this.theLabel);
            this.panel8.Controls.Add(this.wedLabel);
            this.panel8.Controls.Add(this.tueLabel);
            this.panel8.Controls.Add(this.monLabel);
            this.panel8.Controls.Add(this.sunLabel);
            this.panel8.Location = new System.Drawing.Point(5, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(747, 49);
            this.panel8.TabIndex = 0;
            // 
            // friLabel
            // 
            this.friLabel.AutoSize = true;
            this.friLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friLabel.Location = new System.Drawing.Point(656, 13);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(76, 39);
            this.friLabel.TabIndex = 2;
            this.friLabel.Text = "FRI";
            // 
            // theLabel
            // 
            this.theLabel.AutoSize = true;
            this.theLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.theLabel.Location = new System.Drawing.Point(545, 13);
            this.theLabel.Name = "theLabel";
            this.theLabel.Size = new System.Drawing.Size(91, 39);
            this.theLabel.TabIndex = 3;
            this.theLabel.Text = "THU";
            // 
            // wedLabel
            // 
            this.wedLabel.AutoSize = true;
            this.wedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wedLabel.Location = new System.Drawing.Point(425, 13);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(100, 39);
            this.wedLabel.TabIndex = 4;
            this.wedLabel.Text = "WED";
            // 
            // tueLabel
            // 
            this.tueLabel.AutoSize = true;
            this.tueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tueLabel.Location = new System.Drawing.Point(292, 13);
            this.tueLabel.Name = "tueLabel";
            this.tueLabel.Size = new System.Drawing.Size(89, 39);
            this.tueLabel.TabIndex = 5;
            this.tueLabel.Text = "TUE";
            // 
            // monLabel
            // 
            this.monLabel.AutoSize = true;
            this.monLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monLabel.Location = new System.Drawing.Point(170, 13);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(99, 39);
            this.monLabel.TabIndex = 6;
            this.monLabel.Text = "MON";
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sunLabel.Location = new System.Drawing.Point(56, 13);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(93, 39);
            this.sunLabel.TabIndex = 1;
            this.sunLabel.Text = "SUN";
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.satLabel.Location = new System.Drawing.Point(775, 18);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(87, 39);
            this.satLabel.TabIndex = 3;
            this.satLabel.Text = "SAT";
            // 
            // recordViewPage
            // 
            this.recordViewPage.AutoScroll = true;
            this.recordViewPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recordViewPage.BackgroundImage")));
            this.recordViewPage.Controls.Add(this.recordViewPanel);
            this.recordViewPage.Location = new System.Drawing.Point(4, 25);
            this.recordViewPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPage.Name = "recordViewPage";
            this.recordViewPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPage.Size = new System.Drawing.Size(867, 343);
            this.recordViewPage.TabIndex = 1;
            this.recordViewPage.UseVisualStyleBackColor = true;
            this.recordViewPage.Enter += new System.EventHandler(this.recordViewPage_Enter);
            this.recordViewPage.Leave += new System.EventHandler(this.recordViewPage_Leave);
            // 
            // recordViewPanel
            // 
            this.recordViewPanel.AutoScroll = true;
            this.recordViewPanel.Controls.Add(this.dtLabel);
            this.recordViewPanel.Controls.Add(this.etLabel);
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
            this.recordViewPanel.Location = new System.Drawing.Point(40, 32);
            this.recordViewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordViewPanel.Name = "recordViewPanel";
            this.recordViewPanel.Size = new System.Drawing.Size(863, 574);
            this.recordViewPanel.TabIndex = 1;
            // 
            // dtLabel
            // 
            this.dtLabel.AutoSize = true;
            this.dtLabel.Location = new System.Drawing.Point(71, 398);
            this.dtLabel.Name = "dtLabel";
            this.dtLabel.Size = new System.Drawing.Size(71, 15);
            this.dtLabel.TabIndex = 17;
            this.dtLabel.Text = "今日飲食:";
            // 
            // etLabel
            // 
            this.etLabel.AutoSize = true;
            this.etLabel.Location = new System.Drawing.Point(68, 376);
            this.etLabel.Name = "etLabel";
            this.etLabel.Size = new System.Drawing.Size(71, 15);
            this.etLabel.TabIndex = 16;
            this.etLabel.Text = "今日運動:";
            // 
            // editViewButton
            // 
            this.editViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editViewButton.Location = new System.Drawing.Point(591, 12);
            this.editViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editViewButton.Name = "editViewButton";
            this.editViewButton.Size = new System.Drawing.Size(107, 41);
            this.editViewButton.TabIndex = 15;
            this.editViewButton.Text = "修改";
            this.editViewButton.UseVisualStyleBackColor = true;
            this.editViewButton.Click += new System.EventHandler(this.editViewButton_Click);
            // 
            // backViewButton
            // 
            this.backViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backViewButton.Location = new System.Drawing.Point(487, 12);
            this.backViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backViewButton.Name = "backViewButton";
            this.backViewButton.Size = new System.Drawing.Size(99, 41);
            this.backViewButton.TabIndex = 14;
            this.backViewButton.Text = "返回";
            this.backViewButton.UseVisualStyleBackColor = true;
            this.backViewButton.Click += new System.EventHandler(this.backViewButton_Click);
            // 
            // BMIViewLabel
            // 
            this.BMIViewLabel.AutoSize = true;
            this.BMIViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.BMIViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BMIViewLabel.Location = new System.Drawing.Point(50, 123);
            this.BMIViewLabel.Name = "BMIViewLabel";
            this.BMIViewLabel.Size = new System.Drawing.Size(395, 39);
            this.BMIViewLabel.TabIndex = 13;
            this.BMIViewLabel.Text = "BMI:XX  (標準/過胖/過瘦)";
            // 
            // targetViewLabel
            // 
            this.targetViewLabel.AutoSize = true;
            this.targetViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.targetViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.targetViewLabel.Location = new System.Drawing.Point(366, 69);
            this.targetViewLabel.Name = "targetViewLabel";
            this.targetViewLabel.Size = new System.Drawing.Size(321, 39);
            this.targetViewLabel.TabIndex = 8;
            this.targetViewLabel.Text = "離目標還有XX kg喔!";
            // 
            // waistlineViewLabel
            // 
            this.waistlineViewLabel.AutoSize = true;
            this.waistlineViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineViewLabel.Location = new System.Drawing.Point(57, 267);
            this.waistlineViewLabel.Name = "waistlineViewLabel";
            this.waistlineViewLabel.Size = new System.Drawing.Size(256, 39);
            this.waistlineViewLabel.TabIndex = 7;
            this.waistlineViewLabel.Text = "腰圍:             cm";
            // 
            // DBPViewLabel
            // 
            this.DBPViewLabel.AutoSize = true;
            this.DBPViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPViewLabel.Location = new System.Drawing.Point(50, 225);
            this.DBPViewLabel.Name = "DBPViewLabel";
            this.DBPViewLabel.Size = new System.Drawing.Size(128, 39);
            this.DBPViewLabel.TabIndex = 6;
            this.DBPViewLabel.Text = "舒張壓:";
            // 
            // SBPViewLabel
            // 
            this.SBPViewLabel.AutoSize = true;
            this.SBPViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPViewLabel.Location = new System.Drawing.Point(50, 175);
            this.SBPViewLabel.Name = "SBPViewLabel";
            this.SBPViewLabel.Size = new System.Drawing.Size(128, 39);
            this.SBPViewLabel.TabIndex = 5;
            this.SBPViewLabel.Text = "收縮壓:";
            // 
            // dateViewLabel
            // 
            this.dateViewLabel.AutoSize = true;
            this.dateViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateViewLabel.Location = new System.Drawing.Point(57, 12);
            this.dateViewLabel.Name = "dateViewLabel";
            this.dateViewLabel.Size = new System.Drawing.Size(107, 39);
            this.dateViewLabel.TabIndex = 3;
            this.dateViewLabel.Text = " 月 日";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 15);
            this.label19.TabIndex = 1;
            // 
            // weightViewLabel
            // 
            this.weightViewLabel.AutoSize = true;
            this.weightViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightViewLabel.Location = new System.Drawing.Point(50, 69);
            this.weightViewLabel.Name = "weightViewLabel";
            this.weightViewLabel.Size = new System.Drawing.Size(256, 39);
            this.weightViewLabel.TabIndex = 0;
            this.weightViewLabel.Text = "體重:              kg";
            // 
            // recordEditPage
            // 
            this.recordEditPage.AutoScroll = true;
            this.recordEditPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recordEditPage.BackgroundImage")));
            this.recordEditPage.Controls.Add(this.editPanel);
            this.recordEditPage.Location = new System.Drawing.Point(4, 25);
            this.recordEditPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordEditPage.Name = "recordEditPage";
            this.recordEditPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordEditPage.Size = new System.Drawing.Size(867, 343);
            this.recordEditPage.TabIndex = 0;
            this.recordEditPage.UseVisualStyleBackColor = true;
            this.recordEditPage.Enter += new System.EventHandler(this.recordEditPage_Enter);
            this.recordEditPage.Leave += new System.EventHandler(this.recordEditPage_Leave);
            // 
            // editPanel
            // 
            this.editPanel.AutoSize = true;
            this.editPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editPanel.Controls.Add(this.addDietRecordButton);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.cancelRecordButton);
            this.editPanel.Controls.Add(this.exerciseCheckBox);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.updateRecordButton);
            this.editPanel.Controls.Add(this.cmLabel);
            this.editPanel.Controls.Add(this.kgLabel);
            this.editPanel.Controls.Add(this.waistlineEditText);
            this.editPanel.Controls.Add(this.weightEditText);
            this.editPanel.Controls.Add(this.addDietButton);
            this.editPanel.Controls.Add(this.recordEditDietLabel);
            this.editPanel.Controls.Add(this.DBPEditText);
            this.editPanel.Controls.Add(this.SBPEditText);
            this.editPanel.Controls.Add(this.dateEditLabel);
            this.editPanel.Controls.Add(this.recordEditTitleLabel);
            this.editPanel.Controls.Add(this.recordEditExerciseLabel);
            this.editPanel.Controls.Add(this.waistlineEditLabel);
            this.editPanel.Controls.Add(this.DBPEditLabel);
            this.editPanel.Controls.Add(this.weightEditLabel);
            this.editPanel.Controls.Add(this.SBPEditLabel);
            this.editPanel.Location = new System.Drawing.Point(3, 0);
            this.editPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(903, 665);
            this.editPanel.TabIndex = 14;
            // 
            // addDietRecordButton
            // 
            this.addDietRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addDietRecordButton.Location = new System.Drawing.Point(258, 507);
            this.addDietRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDietRecordButton.Name = "addDietRecordButton";
            this.addDietRecordButton.Size = new System.Drawing.Size(90, 34);
            this.addDietRecordButton.TabIndex = 28;
            this.addDietRecordButton.Text = "新增";
            this.addDietRecordButton.UseVisualStyleBackColor = true;
            this.addDietRecordButton.Click += new System.EventHandler(this.addDietRecordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(389, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "mmHg";
            // 
            // cancelRecordButton
            // 
            this.cancelRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancelRecordButton.Location = new System.Drawing.Point(708, 10);
            this.cancelRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelRecordButton.Name = "cancelRecordButton";
            this.cancelRecordButton.Size = new System.Drawing.Size(92, 36);
            this.cancelRecordButton.TabIndex = 16;
            this.cancelRecordButton.Text = "取消";
            this.cancelRecordButton.UseVisualStyleBackColor = true;
            this.cancelRecordButton.Click += new System.EventHandler(this.cancelRecordButton_Click);
            // 
            // exerciseCheckBox
            // 
            this.exerciseCheckBox.FormattingEnabled = true;
            this.exerciseCheckBox.Location = new System.Drawing.Point(74, 361);
            this.exerciseCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exerciseCheckBox.Name = "exerciseCheckBox";
            this.exerciseCheckBox.Size = new System.Drawing.Size(472, 124);
            this.exerciseCheckBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(389, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "mmHg";
            // 
            // updateRecordButton
            // 
            this.updateRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateRecordButton.Location = new System.Drawing.Point(529, 11);
            this.updateRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateRecordButton.Name = "updateRecordButton";
            this.updateRecordButton.Size = new System.Drawing.Size(165, 35);
            this.updateRecordButton.TabIndex = 15;
            this.updateRecordButton.Text = "確認修改";
            this.updateRecordButton.UseVisualStyleBackColor = true;
            this.updateRecordButton.Click += new System.EventHandler(this.updateRecordButton_Click);
            // 
            // cmLabel
            // 
            this.cmLabel.AutoSize = true;
            this.cmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmLabel.Location = new System.Drawing.Point(325, 254);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(52, 31);
            this.cmLabel.TabIndex = 25;
            this.cmLabel.Text = "cm";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kgLabel.Location = new System.Drawing.Point(314, 120);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(49, 36);
            this.kgLabel.TabIndex = 24;
            this.kgLabel.Text = "kg";
            // 
            // waistlineEditText
            // 
            this.waistlineEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditText.Location = new System.Drawing.Point(238, 249);
            this.waistlineEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waistlineEditText.Name = "waistlineEditText";
            this.waistlineEditText.Size = new System.Drawing.Size(73, 38);
            this.waistlineEditText.TabIndex = 23;
            // 
            // weightEditText
            // 
            this.weightEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditText.Location = new System.Drawing.Point(244, 114);
            this.weightEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightEditText.Name = "weightEditText";
            this.weightEditText.Size = new System.Drawing.Size(55, 38);
            this.weightEditText.TabIndex = 22;
            // 
            // addDietButton
            // 
            this.addDietButton.Location = new System.Drawing.Point(119, 416);
            this.addDietButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDietButton.Name = "addDietButton";
            this.addDietButton.Size = new System.Drawing.Size(67, 26);
            this.addDietButton.TabIndex = 18;
            this.addDietButton.Text = "新增";
            this.addDietButton.UseVisualStyleBackColor = true;
            // 
            // recordEditDietLabel
            // 
            this.recordEditDietLabel.AutoSize = true;
            this.recordEditDietLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditDietLabel.Location = new System.Drawing.Point(52, 507);
            this.recordEditDietLabel.Name = "recordEditDietLabel";
            this.recordEditDietLabel.Size = new System.Drawing.Size(196, 46);
            this.recordEditDietLabel.TabIndex = 16;
            this.recordEditDietLabel.Text = "今日飲食:";
            // 
            // DBPEditText
            // 
            this.DBPEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditText.Location = new System.Drawing.Point(275, 208);
            this.DBPEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBPEditText.Name = "DBPEditText";
            this.DBPEditText.Size = new System.Drawing.Size(89, 38);
            this.DBPEditText.TabIndex = 15;
            // 
            // SBPEditText
            // 
            this.SBPEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditText.Location = new System.Drawing.Point(275, 163);
            this.SBPEditText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SBPEditText.Name = "SBPEditText";
            this.SBPEditText.Size = new System.Drawing.Size(89, 38);
            this.SBPEditText.TabIndex = 14;
            // 
            // dateEditLabel
            // 
            this.dateEditLabel.AutoSize = true;
            this.dateEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateEditLabel.Location = new System.Drawing.Point(15, 10);
            this.dateEditLabel.Name = "dateEditLabel";
            this.dateEditLabel.Size = new System.Drawing.Size(169, 54);
            this.dateEditLabel.TabIndex = 0;
            this.dateEditLabel.Text = "x年x日";
            // 
            // recordEditTitleLabel
            // 
            this.recordEditTitleLabel.AutoSize = true;
            this.recordEditTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditTitleLabel.Location = new System.Drawing.Point(42, 64);
            this.recordEditTitleLabel.Name = "recordEditTitleLabel";
            this.recordEditTitleLabel.Size = new System.Drawing.Size(196, 46);
            this.recordEditTitleLabel.TabIndex = 2;
            this.recordEditTitleLabel.Text = "今日紀錄:";
            // 
            // recordEditExerciseLabel
            // 
            this.recordEditExerciseLabel.AutoSize = true;
            this.recordEditExerciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditExerciseLabel.Location = new System.Drawing.Point(52, 306);
            this.recordEditExerciseLabel.Name = "recordEditExerciseLabel";
            this.recordEditExerciseLabel.Size = new System.Drawing.Size(196, 46);
            this.recordEditExerciseLabel.TabIndex = 3;
            this.recordEditExerciseLabel.Text = "今日運動:";
            // 
            // waistlineEditLabel
            // 
            this.waistlineEditLabel.AutoSize = true;
            this.waistlineEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditLabel.Location = new System.Drawing.Point(138, 249);
            this.waistlineEditLabel.Name = "waistlineEditLabel";
            this.waistlineEditLabel.Size = new System.Drawing.Size(97, 39);
            this.waistlineEditLabel.TabIndex = 9;
            this.waistlineEditLabel.Text = "腰圍:";
            // 
            // DBPEditLabel
            // 
            this.DBPEditLabel.AutoSize = true;
            this.DBPEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditLabel.Location = new System.Drawing.Point(138, 206);
            this.DBPEditLabel.Name = "DBPEditLabel";
            this.DBPEditLabel.Size = new System.Drawing.Size(132, 39);
            this.DBPEditLabel.TabIndex = 11;
            this.DBPEditLabel.Text = "舒張壓:";
            // 
            // weightEditLabel
            // 
            this.weightEditLabel.AutoSize = true;
            this.weightEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditLabel.Location = new System.Drawing.Point(138, 117);
            this.weightEditLabel.Name = "weightEditLabel";
            this.weightEditLabel.Size = new System.Drawing.Size(97, 39);
            this.weightEditLabel.TabIndex = 7;
            this.weightEditLabel.Text = "體重:";
            // 
            // SBPEditLabel
            // 
            this.SBPEditLabel.AutoSize = true;
            this.SBPEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditLabel.Location = new System.Drawing.Point(138, 166);
            this.SBPEditLabel.Name = "SBPEditLabel";
            this.SBPEditLabel.Size = new System.Drawing.Size(132, 39);
            this.SBPEditLabel.TabIndex = 10;
            this.SBPEditLabel.Text = "收縮壓:";
            // 
            // summaryPage
            // 
            this.summaryPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("summaryPage.BackgroundImage")));
            this.summaryPage.Controls.Add(this.thismonthLabel);
            this.summaryPage.Controls.Add(this.nextmonthButton);
            this.summaryPage.Controls.Add(this.lastmonthButton);
            this.summaryPage.Controls.Add(this.chart);
            this.summaryPage.Controls.Add(this.summaryTitle);
            this.summaryPage.Controls.Add(this.excriseChartbutton);
            this.summaryPage.Controls.Add(this.caloriebutton);
            this.summaryPage.Controls.Add(this.weightbutton);
            this.summaryPage.Location = new System.Drawing.Point(26, 4);
            this.summaryPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryPage.Name = "summaryPage";
            this.summaryPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryPage.Size = new System.Drawing.Size(881, 383);
            this.summaryPage.TabIndex = 1;
            this.summaryPage.Text = "統計";
            this.summaryPage.UseVisualStyleBackColor = true;
            this.summaryPage.Enter += new System.EventHandler(this.summaryPage_Enter);
            // 
            // thismonthLabel
            // 
            this.thismonthLabel.AutoSize = true;
            this.thismonthLabel.Location = new System.Drawing.Point(776, 34);
            this.thismonthLabel.Name = "thismonthLabel";
            this.thismonthLabel.Size = new System.Drawing.Size(41, 15);
            this.thismonthLabel.TabIndex = 7;
            this.thismonthLabel.Text = "label3";
            // 
            // nextmonthButton
            // 
            this.nextmonthButton.Location = new System.Drawing.Point(848, 24);
            this.nextmonthButton.Name = "nextmonthButton";
            this.nextmonthButton.Size = new System.Drawing.Size(85, 39);
            this.nextmonthButton.TabIndex = 6;
            this.nextmonthButton.Text = "下月";
            this.nextmonthButton.UseVisualStyleBackColor = true;
            // 
            // lastmonthButton
            // 
            this.lastmonthButton.Location = new System.Drawing.Point(667, 24);
            this.lastmonthButton.Name = "lastmonthButton";
            this.lastmonthButton.Size = new System.Drawing.Size(89, 39);
            this.lastmonthButton.TabIndex = 5;
            this.lastmonthButton.Text = "上月";
            this.lastmonthButton.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(80, 184);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart.Size = new System.Drawing.Size(843, 422);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            title1.Name = "體重折線圖";
            this.chart.Titles.Add(title1);
            // 
            // summaryTitle
            // 
            this.summaryTitle.AutoSize = true;
            this.summaryTitle.Location = new System.Drawing.Point(34, 25);
            this.summaryTitle.Name = "summaryTitle";
            this.summaryTitle.Size = new System.Drawing.Size(52, 15);
            this.summaryTitle.TabIndex = 3;
            this.summaryTitle.Text = "統計圖";
            // 
            // excriseChartbutton
            // 
            this.excriseChartbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.excriseChartbutton.Location = new System.Drawing.Point(612, 119);
            this.excriseChartbutton.Name = "excriseChartbutton";
            this.excriseChartbutton.Size = new System.Drawing.Size(98, 40);
            this.excriseChartbutton.TabIndex = 2;
            this.excriseChartbutton.Text = "運動";
            this.excriseChartbutton.UseVisualStyleBackColor = false;
            this.excriseChartbutton.Click += new System.EventHandler(this.excriseChartbutton_Click);
            // 
            // caloriebutton
            // 
            this.caloriebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.caloriebutton.Location = new System.Drawing.Point(397, 119);
            this.caloriebutton.Name = "caloriebutton";
            this.caloriebutton.Size = new System.Drawing.Size(124, 40);
            this.caloriebutton.TabIndex = 1;
            this.caloriebutton.Text = "卡路里攝取";
            this.caloriebutton.UseVisualStyleBackColor = false;
            this.caloriebutton.Click += new System.EventHandler(this.caloriebutton_Click);
            // 
            // weightbutton
            // 
            this.weightbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.weightbutton.Location = new System.Drawing.Point(207, 119);
            this.weightbutton.Name = "weightbutton";
            this.weightbutton.Size = new System.Drawing.Size(106, 42);
            this.weightbutton.TabIndex = 0;
            this.weightbutton.Text = "體重變化";
            this.weightbutton.UseVisualStyleBackColor = false;
            this.weightbutton.Click += new System.EventHandler(this.weightbutton_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.AutoScroll = true;
            this.settingsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsPage.BackgroundImage")));
            this.settingsPage.Controls.Add(this.settingPanel);
            this.settingsPage.Location = new System.Drawing.Point(26, 4);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(881, 383);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "設定";
            this.settingsPage.UseVisualStyleBackColor = true;
            this.settingsPage.Enter += new System.EventHandler(this.settingsPage_Enter);
            this.settingsPage.Leave += new System.EventHandler(this.settingsPage_Leave);
            // 
            // settingPanel
            // 
            this.settingPanel.AutoSize = true;
            this.settingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingPanel.Controls.Add(this.settingPageTitleLabel);
            this.settingPanel.Controls.Add(this.CheckSettingbutton);
            this.settingPanel.Controls.Add(this.NoradioButton);
            this.settingPanel.Controls.Add(this.YesradioButton);
            this.settingPanel.Controls.Add(this.addSettingExerciseButton);
            this.settingPanel.Controls.Add(this.StartDateLabel);
            this.settingPanel.Controls.Add(this.settingExerciseTitleLabel);
            this.settingPanel.Controls.Add(this.PermissionPanel);
            this.settingPanel.Controls.Add(this.HeightText);
            this.settingPanel.Controls.Add(this.StartDateCombo);
            this.settingPanel.Controls.Add(this.PermissionLabel);
            this.settingPanel.Controls.Add(this.mLabel);
            this.settingPanel.Controls.Add(this.HeightLabel);
            this.settingPanel.Location = new System.Drawing.Point(17, 20);
            this.settingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(764, 610);
            this.settingPanel.TabIndex = 1;
            // 
            // settingPageTitleLabel
            // 
            this.settingPageTitleLabel.AutoSize = true;
            this.settingPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingPageTitleLabel.Location = new System.Drawing.Point(13, 6);
            this.settingPageTitleLabel.Name = "settingPageTitleLabel";
            this.settingPageTitleLabel.Size = new System.Drawing.Size(181, 42);
            this.settingPageTitleLabel.TabIndex = 19;
            this.settingPageTitleLabel.Text = "基本設定:";
            // 
            // CheckSettingbutton
            // 
            this.CheckSettingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckSettingbutton.BackgroundImage")));
            this.CheckSettingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSettingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckSettingbutton.Location = new System.Drawing.Point(636, 20);
            this.CheckSettingbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckSettingbutton.Name = "CheckSettingbutton";
            this.CheckSettingbutton.Size = new System.Drawing.Size(106, 52);
            this.CheckSettingbutton.TabIndex = 18;
            this.CheckSettingbutton.Text = "確認";
            this.CheckSettingbutton.UseVisualStyleBackColor = true;
            this.CheckSettingbutton.Click += new System.EventHandler(this.CheckSettingbutton_Click);
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoradioButton.Location = new System.Drawing.Point(380, 281);
            this.NoradioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(89, 46);
            this.NoradioButton.TabIndex = 17;
            this.NoradioButton.TabStop = true;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            this.NoradioButton.CheckedChanged += new System.EventHandler(this.NoradioButton_CheckedChanged);
            // 
            // YesradioButton
            // 
            this.YesradioButton.AutoSize = true;
            this.YesradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YesradioButton.Location = new System.Drawing.Point(255, 281);
            this.YesradioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YesradioButton.Name = "YesradioButton";
            this.YesradioButton.Size = new System.Drawing.Size(107, 46);
            this.YesradioButton.TabIndex = 16;
            this.YesradioButton.TabStop = true;
            this.YesradioButton.Text = "Yes";
            this.YesradioButton.UseVisualStyleBackColor = true;
            this.YesradioButton.CheckedChanged += new System.EventHandler(this.YesradioButton_CheckedChanged);
            // 
            // addSettingExerciseButton
            // 
            this.addSettingExerciseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSettingExerciseButton.BackgroundImage")));
            this.addSettingExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSettingExerciseButton.Location = new System.Drawing.Point(402, 505);
            this.addSettingExerciseButton.Name = "addSettingExerciseButton";
            this.addSettingExerciseButton.Size = new System.Drawing.Size(123, 46);
            this.addSettingExerciseButton.TabIndex = 15;
            this.addSettingExerciseButton.Text = "新增";
            this.addSettingExerciseButton.UseVisualStyleBackColor = true;
            this.addSettingExerciseButton.Click += new System.EventHandler(this.addSettingExerciseButton_Click);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateLabel.Location = new System.Drawing.Point(123, 77);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(277, 54);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "起始日設定:";
            // 
            // settingExerciseTitleLabel
            // 
            this.settingExerciseTitleLabel.AutoSize = true;
            this.settingExerciseTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingExerciseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingExerciseTitleLabel.Location = new System.Drawing.Point(119, 421);
            this.settingExerciseTitleLabel.Name = "settingExerciseTitleLabel";
            this.settingExerciseTitleLabel.Size = new System.Drawing.Size(229, 54);
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
            this.PermissionPanel.Location = new System.Drawing.Point(224, 325);
            this.PermissionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermissionPanel.Name = "PermissionPanel";
            this.PermissionPanel.Size = new System.Drawing.Size(382, 63);
            this.PermissionPanel.TabIndex = 11;
            this.PermissionPanel.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Location = new System.Drawing.Point(258, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 39);
            this.label39.TabIndex = 12;
            this.label39.Text = ":";
            // 
            // MinuteSetCombo
            // 
            this.MinuteSetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.MinuteSetCombo.Location = new System.Drawing.Point(300, 11);
            this.MinuteSetCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinuteSetCombo.Name = "MinuteSetCombo";
            this.MinuteSetCombo.Size = new System.Drawing.Size(64, 44);
            this.MinuteSetCombo.TabIndex = 2;
            // 
            // HourSetCombo
            // 
            this.HourSetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourSetCombo.FormattingEnabled = true;
            this.HourSetCombo.Items.AddRange(new object[] {
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
            "23"});
            this.HourSetCombo.Location = new System.Drawing.Point(190, 11);
            this.HourSetCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourSetCombo.Name = "HourSetCombo";
            this.HourSetCombo.Size = new System.Drawing.Size(63, 44);
            this.HourSetCombo.TabIndex = 1;
            // 
            // TimeSetLabel
            // 
            this.TimeSetLabel.AutoSize = true;
            this.TimeSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeSetLabel.Location = new System.Drawing.Point(6, 14);
            this.TimeSetLabel.Name = "TimeSetLabel";
            this.TimeSetLabel.Size = new System.Drawing.Size(167, 39);
            this.TimeSetLabel.TabIndex = 0;
            this.TimeSetLabel.Text = "提醒時間:";
            // 
            // HeightText
            // 
            this.HeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightText.Location = new System.Drawing.Point(287, 164);
            this.HeightText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(89, 53);
            this.HeightText.TabIndex = 7;
            // 
            // StartDateCombo
            // 
            this.StartDateCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateCombo.FormattingEnabled = true;
            this.StartDateCombo.Items.AddRange(new object[] {
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
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.StartDateCombo.Location = new System.Drawing.Point(397, 54);
            this.StartDateCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDateCombo.Name = "StartDateCombo";
            this.StartDateCombo.Size = new System.Drawing.Size(69, 54);
            this.StartDateCombo.TabIndex = 6;
            // 
            // PermissionLabel
            // 
            this.PermissionLabel.AutoSize = true;
            this.PermissionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PermissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PermissionLabel.Location = new System.Drawing.Point(119, 222);
            this.PermissionLabel.Name = "PermissionLabel";
            this.PermissionLabel.Size = new System.Drawing.Size(434, 54);
            this.PermissionLabel.TabIndex = 5;
            this.PermissionLabel.Text = "是否發出推播通知?";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.BackColor = System.Drawing.Color.Transparent;
            this.mLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mLabel.Location = new System.Drawing.Point(406, 174);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(49, 42);
            this.mLabel.TabIndex = 3;
            this.mLabel.Text = "m";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightLabel.Location = new System.Drawing.Point(123, 164);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(133, 54);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "身高:";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.todayLabel.Location = new System.Drawing.Point(732, 33);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(41, 15);
            this.todayLabel.TabIndex = 20;
            this.todayLabel.Text = "label3";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "該新增資料囉！";
            this.notifyIcon.BalloonTipTitle = "Health Calendar";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Health Calendar";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1191, 702);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.mainTabControl);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Health_Calendar";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
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
            this.recordEditPage.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.summaryPage.ResumeLayout(false);
            this.summaryPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.PermissionPanel.ResumeLayout(false);
            this.PermissionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel editPanel;
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
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.ComboBox StartDateCombo;
        private System.Windows.Forms.Label PermissionLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label settingExerciseTitleLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label friLabel;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.Label theLabel;
        private System.Windows.Forms.Label wedLabel;
        private System.Windows.Forms.Label tueLabel;
        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.Button addSettingExerciseButton;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.RadioButton YesradioButton;
        private System.Windows.Forms.Button CheckSettingbutton;
        private System.Windows.Forms.Button updateRecordButton;
        private System.Windows.Forms.Button cancelRecordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editViewButton;
        private System.Windows.Forms.Button backViewButton;
        private System.Windows.Forms.Button addDietRecordButton;
        private System.Windows.Forms.Label settingPageTitleLabel;
        private Label summaryTitle;
        private Button excriseChartbutton;
        private Button caloriebutton;
        private Button weightbutton;
        private Label todayLabel;
        private Label etLabel;
        private Label dtLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label thismonthLabel;
        private Button nextmonthButton;
        private Button lastmonthButton;
        private NotifyIcon notifyIcon;
    }
}

