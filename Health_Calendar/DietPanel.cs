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
    public partial class DietPanel : UserControl
    {
        private int initX, initY, index;
        private MainWindow parent;
        public int meal, calorie;
        public string diet;

        public DietPanel(MainWindow p, int index, int x, int y)
        {
            InitializeComponent();
            initX = x;
            initY = y;
            parent = p;
            setPosition(index);
            Show();
        }

        public void setPosition(int index)
        {
            this.index = index;
            Location = new Point(initX, initY + index * (Height + 30));
        }

        public void setData(int m, int c, string d)
        {
            meal = m;
            calorie = c;
            diet = d;
            mealComboBox.SelectedIndex = m - 1;
            calorieText.Text = calorie.ToString();
            dietText.Text = diet;
        }

        private void mealComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            meal = mealComboBox.SelectedIndex + 1;
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

        private void dietText_TextChanged(object sender, EventArgs e)
        {
            if (dietText.Text != "")
            {
                calorieText.BackColor = Color.White;
                diet = dietText.Text;
            }
            else
                calorieText.BackColor = Color.LightCoral;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            parent.removeDietPanel(index);
        }

        public bool checkValid()
        {
            bool valid = true;
            if (mealComboBox.SelectedItem == null)
            {
                valid = false;
                mealComboBox.BackColor = Color.LightCoral;
            }
            else
            {
                mealComboBox.BackColor = Color.White;
            }

            if (dietText.Text == "")
            {
                valid = false;
                dietText.BackColor = Color.LightCoral;
            }
            else
            {
                dietText.BackColor = Color.White;
            }

            return valid;
        }
    }
}
