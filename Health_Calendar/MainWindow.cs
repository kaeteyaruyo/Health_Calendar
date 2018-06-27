﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Health_Calendar
{
    public partial class MainWindow : Form
    {
        private DateTime activeDate;
        private DailyRecord activeRecord;
        public static PrivateFontCollection fonts;
 


        public MainWindow()
        {
            

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 600);
            MaximumSize = new Size(800, 600);
            fonts = new PrivateFontCollection();
            fonts.AddFontFile("font1.ttc");
            
            Exercise.selectAllExercise();
        }




        private void MainWindow_Load(object sender, EventArgs e)
        {
           
            mainTabControl.Size = new Size(720, 455);
            mainTabControl.ItemSize = new Size(150, 25);
            mainTabControl.Location = new Point((this.Size.Width - mainTabControl.Size.Width)/2 - 15, (this.Size.Height - mainTabControl.Size.Height) / 2);
            calendarTabControl.Size = new Size(720, 455);
            calendarTabControl.Location = new Point(0, 0);
            generate_calendar(2018, 6);
            calendarTabControl.ItemSize = new Size(0, 1);
            calendarTabControl.SizeMode = TabSizeMode.Fixed;
            this.sunLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tueLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wedLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.theLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.satLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editViewButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BMIViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backViewButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.targetViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightViewLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addDietRecordButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancelRecordButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateRecordButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmLabel.Font = new System.Drawing.Font(fonts.Families[0], 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kgLabel.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditText.Font = new System.Drawing.Font(fonts.Families[0], 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditText.Font = new System.Drawing.Font(fonts.Families[0], 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditDietLabel.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditText.Font = new System.Drawing.Font(fonts.Families[0], 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditText.Font = new System.Drawing.Font(fonts.Families[0], 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateEditLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditTitleLabel.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recordEditExerciseLabel.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.waistlineEditLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DBPEditLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightEditLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SBPEditLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingPageTitleLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckSettingbutton.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoradioButton.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YesradioButton.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSettingExerciseButton.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingExerciseTitleLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteSetCombo.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourSetCombo.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeSetLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OlderText.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightText.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateCombo.Font = new System.Drawing.Font(fonts.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PermissionLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OlderLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightLabel.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));





        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;
            StrFormat.Alignment = StringAlignment.Center;
            Font font = new Font(fonts.Families[0], 12, GraphicsUnit.Pixel);
            string text = mainTabControl.TabPages[e.Index].Text;
            Rectangle rect = mainTabControl.GetTabRect(e.Index);
            g.DrawString(text, mainTabControl.Font, Brushes.Black, rect, StrFormat);
        }

        private void generate_calendar(int year, int month)
        {
            int[] W = new int[12] { 6, 2, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            int[] D = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int w = W[month - 1] + year + (year / 4) - (year / 100) + (year / 400);
            int X = 25, Y = 60;
            if (((year % 4) == 0) && (month < 3))
            {
                w--;
                D[1]++;
                if ((year % 100) == 0)
                {
                    w++;
                    D[1]--;
                }
                if ((year % 400) == 0)
                {
                    w--;
                    D[1]++;
                }
            }

            for (int i = 1, j = 0; i <= D[month - 1]; i++)
            {
                DateButton dateBtn = new DateButton(X + 90 * ((w + i) % 7), Y + 70 * j, new DateTime(year, month, i), "");
                dateBtn.Font = new Font(fonts.Families[0], 18, System.Drawing.FontStyle.Bold);
                dateBtn.Click += (sender, e) => DateButton_Click(sender, e, dateBtn.date);
                calendarPage.Controls.Add(dateBtn);
                if ((w + i) % 7 == 6) j++;
            }
        }
        public void DateButton_Click(object sender, EventArgs e, DateTime d)
        {
            activeDate = d;
            if (DateTime.Compare(d, DateTime.Today) < 0)
                calendarTabControl.SelectedTab = recordViewPage;
            else if (DateTime.Compare(d, DateTime.Today) == 0)
                calendarTabControl.SelectedTab = recordEditPage;
            else
                MessageBox.Show("還不能新增記錄喔~", "Future Date");
        }

        private void recordViewPage_Enter(object sender, EventArgs e)
        {
            activeRecord = new DailyRecord(activeDate);
            dateViewLabel.Text = activeDate.Month + " 月 " + activeDate.Day + " 日";
            weightViewLabel.Text = "體重： " + activeRecord.weight + " kg";
            waistlineViewLabel.Text = "腰圍： " + activeRecord.waistline + " cm";
            SBPViewLabel.Text = "收縮壓： " + activeRecord.SBP + " mmHg";
            DBPViewLabel.Text = "舒張壓： " + activeRecord.DBP + " mmHg";
            BMIViewLabel.Text = "BMI： " + activeRecord.BMI;
        }

        private void recordViewPage_Leave(object sender, EventArgs e)
        {
            if (activeRecord != null)
                activeRecord = null;
        }

        private void recordEditPage_Enter(object sender, EventArgs e)
        {
            activeRecord = new DailyRecord(activeDate);
            dateEditLabel.Text = activeDate.Month + " 月 " + activeDate.Day + " 日";

            if (activeRecord.modified)
            {
                weightEditText.Text = activeRecord.weight.ToString();
                waistlineEditText.Text = activeRecord.waistline.ToString();
                SBPEditText.Text = activeRecord.SBP.ToString();
                DBPEditText.Text = activeRecord.DBP.ToString();
            }

            foreach (Exercise ex in Exercise.exerciseList)
                exerciseCheckBox.Items.Add(ex.title);
            foreach (Exercise ex in activeRecord.exercises)
                for (int i = 0; i < exerciseCheckBox.Items.Count; ++i)
                    if (exerciseCheckBox.Items[i].ToString() == ex.title)
                    {
                        exerciseCheckBox.SetItemChecked(i, true);
                        break;
                    }

        }

        private void recordEditPage_Leave(object sender, EventArgs e)
        {
            if (activeRecord != null)
                activeRecord = null;
        }

        private void backViewButton_Click(object sender, EventArgs e)
        {
            calendarTabControl.SelectedTab = calendarPage;
        }

        private void editViewButton_Click(object sender, EventArgs e)
        {
            calendarTabControl.SelectedTab = recordEditPage;
        }

        private void updateRecordButton_Click(object sender, EventArgs e)
        {
            activeRecord.weight = Convert.ToInt32(weightEditText.Text);
            activeRecord.waistline = Convert.ToInt32(waistlineEditText.Text);
            activeRecord.SBP = Convert.ToInt32(SBPEditText.Text);
            activeRecord.DBP = Convert.ToInt32(DBPEditText.Text);
            //activeRecord.diets.Clear();
            
            activeRecord.update();
            calendarTabControl.SelectedTab = recordViewPage;
        }
        private void cancelRecordButton_Click(object sender, EventArgs e)
        {
            calendarTabControl.SelectedTab = recordViewPage;
        }

        
    }
}
