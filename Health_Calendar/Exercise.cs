using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Health_Calendar
{
    class Exercise
    {
        public string title;
        public string detail;
        public int id;
        public int timeLength;
        public int calorie;

        public static List<Exercise> exerciseList = new List<Exercise>();

        public Exercise(int id, string title, string detail, int timeLength, int calorie)
        {
            this.id = id;
            this.title = title;
            this.detail = detail;
            this.timeLength = timeLength;
            this.calorie = calorie;
        }
        public static void selectAllExercise()
        {
            exerciseList.Clear();
            using (SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True"))
            {
                SqlDataAdapter query = null;
                DataSet data = new DataSet();
                try
                {
                    query = new SqlDataAdapter("select exercise_id, title, detail, time_length, calorie from plan_exercise", database);
                    query.Fill(data, "exercise");

                    if (data.Tables["exercise"].Rows.Count != 0)
                    {
                        foreach (DataRow r in data.Tables["exercise"].Rows)
                            exerciseList.Add(new Exercise(Convert.ToInt32(r["exercise_id"]), r["title"].ToString(), r["detail"].ToString(), Convert.ToInt32(r["time_length"]), Convert.ToInt32(r["calorie"])));
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }

        }
    }
}
