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
    public partial class ExerciseViewPanel : UserControl
    {
        public ExerciseViewPanel()
        {
            InitializeComponent();
            Show();
        }
        public void EditExercise(String title,int calorie,String detail,int time)
        {
            titleViewLabel.Text = title;
            TimeLengthLabel.Text = "運動:"+time.ToString()+"min";
            kcalViewLabel.Text = "消耗" + calorie.ToString() + "kcal";
            detailViewLabel.Text = "*" + detail;
         
        }

    }
}
