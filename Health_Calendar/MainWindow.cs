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
            ShowDialog();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center; 
            StrFormat.Alignment = StringAlignment.Center;
            Font font = new Font("新細明體", 12, GraphicsUnit.Pixel);
            string text = tabControl1.TabPages[e.Index].Text;
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            g.DrawString(text, tabControl1.Font, Brushes.Black, rect, StrFormat);
        }
    }
}
