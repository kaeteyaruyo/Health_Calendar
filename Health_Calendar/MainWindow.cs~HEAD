using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Calendar
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 600);
            MaximumSize = new Size(800, 600);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mainTabControl.Size = new Size(720, 455);
            mainTabControl.ItemSize = new Size(150, 25);
            mainTabControl.Location = new Point((this.Size.Width - mainTabControl.Size.Width)/2 - 15, (this.Size.Height - mainTabControl.Size.Height) / 2);
            generate_calendar(2018, 6);
        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;
            StrFormat.Alignment = StringAlignment.Center;
            Font font = new Font("新細明體", 12, GraphicsUnit.Pixel);
            string text = mainTabControl.TabPages[e.Index].Text;
            Rectangle rect = mainTabControl.GetTabRect(e.Index);
            g.DrawString(text, mainTabControl.Font, Brushes.Black, rect, StrFormat);
        }

        private void generate_calendar(int year, int month)
        {
            int[] W = new int[12] { 6, 2, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            int[] D = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int w = W[month - 1] + year + (year / 4) - (year / 100) + (year / 400);
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

            int[] x = new int[7] { 45, 135, 225, 315, 405, 495, 585 };
            int[] y = new int[6] { 60, 130, 200, 270, 340, 410 };
            for (int i = 1, j = 0; i <= D[month - 1]; i++)
            {
                calendarPage.Controls.Add(new DateButton(x[(w + i) % 7], y[j], new DateTime(year, month, i), ""));
                if ((w + i) % 7 == 6) j++;
            }
        }
    }
}
