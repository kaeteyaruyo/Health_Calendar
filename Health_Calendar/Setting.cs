using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Health_Calendar
{
    class Setting
    {
        public int startDate;
        public double height;
        public bool alarm;
        public int alarmHour;
        public int alarmMinute;
        private string connectionString;
        public Setting()
        {
            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True";
            select();
        }

        public void select()
        {
            SqlDataAdapter query;
            DataSet data = new DataSet();

            using (SqlConnection database = new SqlConnection(connectionString))
            {
                try
                {
                    query = new SqlDataAdapter("select startDate, height, alarm, alarmHour, alarmMinute from setting", database);
                    query.Fill(data, "setting");
                    if (data.Tables["setting"].Rows.Count != 0)
                    {
                        startDate = Convert.ToInt32(data.Tables["setting"].Rows[0]["startDate"]);
                        height = Convert.ToDouble(data.Tables["setting"].Rows[0]["height"]);
                        alarm = Convert.ToBoolean(data.Tables["setting"].Rows[0]["alarm"]);
                        alarmHour = Convert.ToInt32(data.Tables["setting"].Rows[0]["alarmHour"]);
                        alarmMinute = Convert.ToInt32(data.Tables["setting"].Rows[0]["alarmMinute"]);
                    }
                    else
                    {
                        Console.WriteLine("No setting data");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }

        public void update()
        {
            using (SqlConnection database = new SqlConnection(connectionString))
            {
                database.Open();
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(
                        "update setting set startDate = " + startDate
                        + ", height = " + height
                        + ", alarm = " + (alarm ? 1 : 0)
                        + ", alarmHour = " + alarmHour
                        + ", alarmMinute = " + alarmMinute
                        + " where id = 1", database);
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
                finally
                {
                    if (command != null) command.Dispose();
                }
            }
        }
    }
}