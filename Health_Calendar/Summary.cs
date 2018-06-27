using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Health_Calendar
{
    class Summary
    {
        public static List<double> weightList = new List<double>();
        public static List<int> inCalorieList = new List<int>();
        public static List<int> outCalorieList = new List<int>();
        public static List<int> exerciseTimeLengthList = new List<int>();
        private static int[] days = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Summary()
        {
        }
        public static void selectWeight(DateTime month)
        {
            weightList.Clear();
            using (SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True"))
            {
                SqlDataAdapter query = null;
                DataSet data = new DataSet();
                try
                {
                    query = new SqlDataAdapter("select date, weight from daily_record where MONTH(date) = " + month.Month + " and YEAR(date) = " + month.Year, database);
                    query.Fill(data, "data");

                    if (data.Tables["data"].Rows.Count != 0)
                    {
                        for (int i = 1; i <= days[month.Month]; ++i)
                        {
                            bool find = false;
                            foreach (DataRow r in data.Tables["data"].Rows)
                            {
                                if (DateTime.Parse(r["date"].ToString()).Day == i)
                                {
                                    find = true;
                                    weightList.Add(Convert.ToDouble(r["weight"]));
                                    break;
                                }
                            }
                            if(!find) weightList.Add(0.0);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
        public static void selectInCalorie(DateTime month)
        {
            weightList.Clear();
            using (SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True"))
            {
                SqlDataAdapter query = null;
                DataSet data = new DataSet();
                try
                {
                    query = new SqlDataAdapter("select date, calorie from daily_diet where MONTH(date) = " + month.Month + " and YEAR(date) = " + month.Year, database);
                    query.Fill(data, "data");

                    if (data.Tables["data"].Rows.Count != 0)
                    {
                        for (int i = 1; i <= days[month.Month]; ++i)
                        {
                            int sum = 0;
                            foreach (DataRow r in data.Tables["data"].Rows)
                            {
                                if (DateTime.Parse(r["date"].ToString()).Day == i)
                                {
                                    sum += Convert.ToInt32(r["calorie"]);
                                }
                            }
                            inCalorieList.Add(sum);
                        }
                    }
                    foreach (int a in inCalorieList)
                        Console.WriteLine(a);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
        public static void selectOutCalorie(DateTime month)
        {
            weightList.Clear();
            using (SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True"))
            {
                SqlDataAdapter query = null;
                DataSet data = new DataSet();
                try
                {
                    query = new SqlDataAdapter("select de.date, pe.calorie from daily_exercise as de, plan_exercise as pe where de.exercise_id = pe.exercise_id and MONTH(date) = " + month.Month + " and YEAR(date) = " + month.Year, database);
                    query.Fill(data, "data");

                    if (data.Tables["data"].Rows.Count != 0)
                    {
                        for (int i = 1; i <= days[month.Month]; ++i)
                        {
                            int sum = 0;
                            foreach (DataRow r in data.Tables["data"].Rows)
                            {
                                if (DateTime.Parse(r["date"].ToString()).Day == i)
                                {
                                    sum += Convert.ToInt32(r["calorie"]);
                                }
                            }
                            outCalorieList.Add(sum);
                        }
                    }
                    foreach (int a in outCalorieList)
                        Console.WriteLine(a);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
        public static void selectTimeLength(DateTime month)
        {
            weightList.Clear();
            using (SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True"))
            {
                SqlDataAdapter query = null;
                DataSet data = new DataSet();
                try
                {
                    query = new SqlDataAdapter("select de.date, pe.time_length from daily_exercise as de, plan_exercise as pe where de.exercise_id = pe.exercise_id and MONTH(date) = " + month.Month + " and YEAR(date) = " + month.Year, database);
                    query.Fill(data, "data");

                    if (data.Tables["data"].Rows.Count != 0)
                    {
                        for (int i = 1; i <= days[month.Month]; ++i)
                        {
                            int sum = 0;
                            foreach (DataRow r in data.Tables["data"].Rows)
                            {
                                if (DateTime.Parse(r["date"].ToString()).Day == i)
                                {
                                    sum += Convert.ToInt32(r["time_length"]);
                                }
                            }
                            exerciseTimeLengthList.Add(sum);
                        }
                    }
                    foreach (int a in exerciseTimeLengthList)
                        Console.WriteLine(a);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
    }
}
