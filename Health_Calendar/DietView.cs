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
    public partial class DietView : UserControl
    {
        public DietView()
        {
            InitializeComponent();
            Show();
        }

        public void DietEdit(String meal, int cal, String detail)
        {
            mealViewLabel.Text = meal;
            calorieViewLabel.Text = "攝入" + cal.ToString() + "kcal";
            detailViewLabel.Text = "*" + detail;

        }
    }
}
