using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Calendar
{
    public partial class ExercisePanel : UserControl
    {
        private int initX, initY, index;
        public int timeLength, calorie;
        public string title, detail;
        private MainWindow parent;

        public ExercisePanel(MainWindow p, int index, int x, int y)
        {
            InitializeComponent();
            initX = x;
            initY = y;
            parent = p;
            Console.WriteLine(index);
            setPosition(index);
            Show();
        }

        public void setPosition(int index)
        {
            this.index = index;
            Location = new Point(initX, initY + index * (Height + 30));
        }

        public void setData(string t, int tl, int c, string d)
        {
            title = t;
            timeLength = tl;
            calorie = c;
            detail = d;
            titleText.Text = title;
            timeLengthText.Text = tl.ToString();
            calorieText.Text = calorie.ToString();
            detailText.Text = detail;
        }

        private void calorieText_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(calorieText.Text, out value))
            {
                calorieText.BackColor = Color.White;
                calorie = value;
            }
            else
                calorieText.BackColor = Color.LightCoral;

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {
            if (titleText.Text != "")
            {
                titleText.BackColor = Color.White;
                title = titleText.Text;
            }
            else
                titleText.BackColor = Color.LightCoral;
        }

        private void timeLengthText_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(timeLengthText.Text, out value))
            {
                timeLengthText.BackColor = Color.White;
                timeLength = value;
            }
            else
                timeLengthText.BackColor = Color.LightCoral;
        }
        private void detailText_TextChanged(object sender, EventArgs e)
        {
            if (detailText.Text != "")
            {
                detailText.BackColor = Color.White;
                detail = detailText.Text;
            }
            else
                detailText.BackColor = Color.LightCoral;
        }


        public bool checkValid()
        {
            bool valid = true;
            int v;
            if (titleText.Text == "")
            {
                valid = false;
                titleText.BackColor = Color.LightCoral;
            }
            else
            {
                titleText.BackColor = Color.White;
            }
            if (!int.TryParse(timeLengthText.Text, out v))
            {
                valid = false;
                timeLengthText.BackColor = Color.LightCoral;
            }
            else
            {
                timeLengthText.BackColor = Color.White;
            }
            if (!int.TryParse(calorieText.Text, out v))
            {
                valid = false;
                calorieText.BackColor = Color.LightCoral;
            }
            else
            {
                calorieText.BackColor = Color.White;
            }
            if (detailText.Text == "")
            {
                valid = false;
                detailText.BackColor = Color.LightCoral;
            }
            else
            {
                detailText.BackColor = Color.White;
            }

            return valid;
        }
    }
}
