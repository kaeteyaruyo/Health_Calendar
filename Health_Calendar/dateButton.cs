using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Health_Calendar
{
    class DateButton : Button
    {
        DateTime date;
        public DateButton(int x, int y, DateTime date, string type)
        {
            Name = "dateBtn" + date.Date.ToString("yyyyMMdd");
            this.date = date;
            Location = new Point(x, y);
            Size = new Size(90, 70);
            Text = date.Day.ToString();
            FlatStyle = FlatStyle.Flat;
            Visible = true;
            // if(type == "") BackColor = ...
            
        }

        protected override void OnClick(EventArgs e)
        {
            DailyRecord s = new DailyRecord(date.Date);
            s.select();
            s.print();
            // parsing data from query and put them into controls
            base.OnClick(e);
        }


    }
}
