using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace Health_Calendar
{
    public partial class MainWindow : Form
    {
        private System.Threading.Timer timer;
        private DateTime activeDate;
        private DailyRecord activeRecord;
        public static PrivateFontCollection fonts;
        private List<DietPanel> dietPanels = new List<DietPanel>();
        Series weight = new Series("體重", 200);
        Series timelenght = new Series("運動時長", 500);
        Series calorieSeries1 = new Series("攝入卡路里", 4000);
        Series calorieSeries2 = new Series("消耗卡路里", 4000);
        private List<ExercisePanel> exercisePanels = new List<ExercisePanel>();
        private Setting setting = new Setting();
        public MainWindow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
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
            generate_calendar(DateTime.Today.Year, DateTime.Today.Month);
            calendarTabControl.ItemSize = new Size(0, 1);
            calendarTabControl.SizeMode = TabSizeMode.Fixed;
            todayLabel.Text = "Today: "+DateTime.Today.Month.ToString()+"月"+DateTime.Today.Day+"日";
            this.todayLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.updateRecordButton.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.CheckSettingbutton.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoradioButton.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YesradioButton.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSettingExerciseButton.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.settingExerciseTitleLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteSetCombo.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourSetCombo.Font = new System.Drawing.Font(fonts.Families[0], 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeSetLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
          
            this.HeightText.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDateCombo.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PermissionLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
           
            this.mLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            
            this.HeightLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excriseChartbutton.Font = new System.Drawing.Font(fonts.Families[0], 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightbutton.Font = new System.Drawing.Font(fonts.Families[0], 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caloriebutton.Font = new System.Drawing.Font(fonts.Families[0], 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.summaryTitle.Font = new System.Drawing.Font(fonts.Families[0], 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.etLabel.Font = new System.Drawing.Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.thismonthLabel.Font = new System.Drawing.Font(fonts.Families[0], 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lastmonthButton.Font = new System.Drawing.Font(fonts.Families[0], 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nextmonthButton.Font = new System.Drawing.Font(fonts.Families[0], 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));


            mainTabControl.Font=new Font(fonts.Families[0], 15, System.Drawing.FontStyle.Bold);
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
            int num=0;
            int x = 55; int y = 300;
            foreach (Exercise ex in activeRecord.exercises)
            {
                
                ExerciseViewPanel exx = new ExerciseViewPanel();
                exx.EditExercise(ex.title,ex.calorie,ex.detail,ex.timeLength);
                recordViewPanel.Controls.Add(exx);
                y = y + num * 200;
                exx.Location=new Point(x, y );
                exx.Font = new Font(fonts.Families[0], 20);
                num++;
                
            }
            y = y + 250;
           
            dtLabel.Font = new Font(fonts.Families[0], 20F, System.Drawing.FontStyle.Bold);
            dtLabel.Location = new Point(x, y);
            
            y += 50;num = 0;
            foreach (Diet dt in activeRecord.diets)
            {

                DietView d = new DietView();
                d.DietEdit(dt.meal, dt.calorie, dt.diet);
                recordViewPanel.Controls.Add(d);
                y = y + num * 200;
                d.Font = new Font(fonts.Families[0], 20);
                d.Location = new Point(x, y);
                num++;
                
            }

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
            else
            {
                weightEditText.Text = "0";
                waistlineEditText.Text = "0";
                SBPEditText.Text = "0";
                DBPEditText.Text = "0";
            }

            foreach (Diet d in activeRecord.diets)
            {
                DietPanel dp = new DietPanel(this, dietPanels.Count, recordEditDietLabel.Location.X, recordEditDietLabel.Location.Y + recordEditDietLabel.Height + 30);
                dp.setData(d.meal_id, d.calorie, d.diet);
                dietPanels.Add(dp);
                editPanel.Controls.Add(dp);
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
            exerciseCheckBox.Items.Clear();
            for (int i = dietPanels.Count - 1; i >= 0; --i)
                removeDietPanel(i);
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
            bool valid = true;
            valid = checkTextNotEmpty(weightEditText);
            valid = checkTextNotEmpty(waistlineEditText);
            valid = checkTextNotEmpty(SBPEditText);
            valid = checkTextNotEmpty(DBPEditText);

            for (int i = 0; i < dietPanels.Count; ++i)
                valid = dietPanels[i].checkValid();

            if (!valid) return;
            else
            {
                activeRecord.weight = Convert.ToInt32(weightEditText.Text);
                activeRecord.waistline = Convert.ToInt32(waistlineEditText.Text);
                activeRecord.SBP = Convert.ToInt32(SBPEditText.Text);
                activeRecord.DBP = Convert.ToInt32(DBPEditText.Text);
                activeRecord.diets.Clear();
                for (int i = 0; i < dietPanels.Count; ++i)
                        activeRecord.diets.Add(new Diet(dietPanels[i].meal, dietPanels[i].diet, dietPanels[i].calorie));

                activeRecord.exercises.Clear();
                foreach (int index in exerciseCheckBox.CheckedIndices)
                    activeRecord.exercises.Add(new Exercise(index + 1, "", "", 0, 0));
                activeRecord.update();
                calendarTabControl.SelectedTab = recordViewPage;
            }
        }
        private void cancelRecordButton_Click(object sender, EventArgs e)
        {
            calendarTabControl.SelectedTab = recordViewPage;
        }

        private void YesradioButton_CheckedChanged(object sender, EventArgs e)
        {
            setPermissionPanel();
        }

        private void NoradioButton_CheckedChanged(object sender, EventArgs e)
        {
            setPermissionPanel();
        }

        private void addDietRecordButton_Click(object sender, EventArgs e)
        {
            DietPanel dp = new DietPanel(this, dietPanels.Count, recordEditDietLabel.Location.X, recordEditDietLabel.Location.Y + recordEditDietLabel.Height + 30);
            dietPanels.Add(dp);
            editPanel.Controls.Add(dp);
        }

        public void removeDietPanel(int index) {
            DietPanel tmp = dietPanels[index];
            dietPanels.RemoveAt(index);
            tmp.Dispose();

            for (int i = 0; i < dietPanels.Count; ++i)
            {
                dietPanels[i].setPosition(i);
            }
        }

        private bool checkTextNotEmpty(TextBox t)
        {
            if (t.Text != "")
            {
                t.BackColor = Color.White;
                return true;
            }
            else
            {
                t.BackColor = Color.LightCoral;
                return false;
            }
        }       

        private void weightbutton_Click(object sender, EventArgs e)
        {
            chart.Series.Remove(timelenght);
            chart.Series.Remove(weight);
            chart.Series.Remove(calorieSeries1);
            chart.Series.Remove(calorieSeries2);

          
            chart.Series.Add(weight);


        }

        private void excriseChartbutton_Click(object sender, EventArgs e)
        {
            chart.Series.Remove(timelenght);
            chart.Series.Remove(weight);
            chart.Series.Remove(calorieSeries1);
            chart.Series.Remove(calorieSeries2);

           
            chart.Series.Add(timelenght);
           

        }

        private void caloriebutton_Click(object sender, EventArgs e)
        {
            chart.Series.Remove(timelenght);
            chart.Series.Remove(weight);
            chart.Series.Remove(calorieSeries1);
            chart.Series.Remove(calorieSeries2);

            chart.Series.Add(calorieSeries1);
            chart.Series.Add(calorieSeries2);
            

        }

        private void summaryPage_Enter(object sender, EventArgs e)
        {
            this.thismonthLabel.Text = DateTime.Today.Month.ToString() + "月";


            weight = new Series("體重");
            weight.Color = Color.Red;
            weight.Font = new System.Drawing.Font(fonts.Families[0], 14);
            weight.ChartType = SeriesChartType.Line;
            weight.IsValueShownAsLabel = true;
            weight.Points.AddXY(2, 40);
            chart.Series.Add(weight);


            timelenght.Color = Color.Red;
            timelenght.Font = new System.Drawing.Font(fonts.Families[0], 14);
            timelenght.ChartType = SeriesChartType.Line;
            timelenght.IsValueShownAsLabel = true;
            timelenght.Points.AddXY(23, 60);

            calorieSeries1.Color = Color.Red;
            calorieSeries2.Color = Color.Blue;
            calorieSeries1.Font = new System.Drawing.Font(fonts.Families[0], 14);
            calorieSeries2.Font = new System.Drawing.Font(fonts.Families[0], 14);
            calorieSeries1.ChartType = SeriesChartType.Bar;
            calorieSeries2.ChartType = SeriesChartType.Bar;
            calorieSeries1.IsValueShownAsLabel = true;
            calorieSeries2.IsValueShownAsLabel = true;
        }

        private bool checkComboBoxSelected(ComboBox c)
        {
            if (c.SelectedItem != null)
            {
                c.BackColor = Color.White;
                return true;
            }
            else
            {
                c.BackColor = Color.LightCoral;
                return false;
            }
        }

        private void settingsPage_Enter(object sender, EventArgs e)
        {
            StartDateCombo.SelectedIndex = setting.startDate - 1;
            Console.WriteLine(setting.height.ToString());
            HeightText.Text = setting.height.ToString();
            if (setting.alarm)
            {
                YesradioButton.Checked = true;
                HourSetCombo.SelectedIndex = setting.alarmHour;
                MinuteSetCombo.SelectedIndex = setting.alarmMinute;
            }
            else
                NoradioButton.Checked = true;
            setPermissionPanel();
            foreach (Exercise ex in Exercise.exerciseList)
            {
                ExercisePanel ep = new ExercisePanel(this, exercisePanels.Count, settingExerciseTitleLabel.Location.X, settingExerciseTitleLabel.Location.Y + settingExerciseTitleLabel.Height + 30);
                ep.setData(ex.title, ex.timeLength, ex.calorie, ex.detail);
                exercisePanels.Add(ep);
                settingPanel.Controls.Add(ep);
                
            }

        }
        private void settingsPage_Leave(object sender, EventArgs e)
        {
            for (int i = exercisePanels.Count - 1; i >= 0; --i)
                removeExercisePanel(i);
        }

        private void addSettingExerciseButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("add exercise panel");
            ExercisePanel ep = new ExercisePanel(this, exercisePanels.Count, settingExerciseTitleLabel.Location.X, settingExerciseTitleLabel.Location.Y + settingExerciseTitleLabel.Height + 30);
            exercisePanels.Add(ep);
            settingPanel.Controls.Add(ep);
        }

        public void removeExercisePanel(int index)
        {
            ExercisePanel tmp = exercisePanels[index];
            exercisePanels.RemoveAt(index);
            tmp.Dispose();
            for (int i = 0; i < exercisePanels.Count; ++i)
            {
                exercisePanels[i].setPosition(i);
            }
        }
        public void setPermissionPanel()
        {
            if (YesradioButton.Checked == true)
                PermissionPanel.Visible = true;

            if (NoradioButton.Checked == true)
                PermissionPanel.Visible = false;
        }

        private void CheckSettingbutton_Click(object sender, EventArgs e)
        {
            bool valid = true;

            valid = checkTextNotEmpty(HeightText);
            valid = checkComboBoxSelected(StartDateCombo);
            valid = checkComboBoxSelected(HourSetCombo);
            valid = checkComboBoxSelected(MinuteSetCombo);
            for (int i = 0; i < exercisePanels.Count; ++i)
                valid = exercisePanels[i].checkValid();

            if (!valid) return;
            else
            {
                setting.startDate = Convert.ToInt32(StartDateCombo.SelectedItem);
                setting.height = Convert.ToDouble(HeightText.Text);
                if (YesradioButton.Checked) setting.alarm = true;
                else setting.alarm = false;
                setting.alarmHour = Convert.ToInt32(HourSetCombo.SelectedItem);
                setting.alarmMinute = Convert.ToInt32(MinuteSetCombo.SelectedItem);
                setting.update();

                Exercise.exerciseList.Clear();
                for(int i = 0; i < exercisePanels.Count; ++i) {
                    Exercise.exerciseList.Add(new Exercise(i + 1, exercisePanels[i].title, exercisePanels[i].detail, exercisePanels[i].timeLength, exercisePanels[i].calorie));
                }
                Exercise.update();
                if (setting.alarm)
                {
                    SetUpTimer(new TimeSpan(setting.alarmHour, setting.alarmMinute, 00));
                }
                else
                    timer = null;
                MessageBox.Show("設定更新完成！", "Setting updated");
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你確定要關閉健康月曆嗎?（按最小化可背景執行）", "確定要離開?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.alarmPopup();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void alarmPopup()
        {
            notifyIcon.ShowBalloonTip(60000);
        }
    }
}
