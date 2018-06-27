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
    class DailyRecord
    {
        public DateTime date;
        public double weight;
        public double waistline;
        public int SBP;
        public int DBP;
        public double BMI;
        public List<Diet> diets = new List<Diet>();
        public List<Exercise> exercises = new List<Exercise>();
        public bool modified;

        private string connectionString;
        public DailyRecord(DateTime date)
        {
            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|health_calendar.mdf;Integrated Security=True";
            this.date = date;
            this.modified = true;
            select();
        }

        public void select()
        {
            SqlDataAdapter query;
            DataSet data = new DataSet();
            double height = 1.6;

            using (SqlConnection database = new SqlConnection(connectionString))
            {
                try
                {
                    query = new SqlDataAdapter("select weight, waistline, SBP, DBP from daily_record where date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                    query.Fill(data, "record");
                    query = new SqlDataAdapter("select meal, diet, calorie from daily_diet where date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                    query.Fill(data, "diet");
                    query = new SqlDataAdapter("select pe.exercise_id, pe.title, pe.detail, pe.time_length, pe.calorie from daily_exercise as de, plan_exercise as pe where de.exercise_id = pe.exercise_id and de.date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                    query.Fill(data, "exercise");

                    if (data.Tables["record"].Rows.Count != 0)
                    {
                        weight = Convert.ToDouble(data.Tables["record"].Rows[0]["weight"]);
                        waistline = Convert.ToDouble(data.Tables["record"].Rows[0]["waistline"]);
                        SBP = Convert.ToInt32(data.Tables["record"].Rows[0]["SBP"]);
                        DBP = Convert.ToInt32(data.Tables["record"].Rows[0]["DBP"]);
                        BMI = weight / (height * height);
                        foreach (DataRow r in data.Tables["diet"].Rows)
                            diets.Add(new Diet(Convert.ToInt32(r["meal"]), r["diet"].ToString(), Convert.ToInt32(r["calorie"])));
                        foreach (DataRow r in data.Tables["exercise"].Rows)
                            exercises.Add(new Exercise(Convert.ToInt32(r["exercise_id"]), r["title"].ToString(), r["detail"].ToString(), Convert.ToInt32(r["time_length"]), Convert.ToInt32(r["calorie"])));
                    }
                    else
                    {
                        Console.WriteLine("No data for today");
                        modified = false;
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
                    if (modified)
                    {
                        command = new SqlCommand(
                            "update daily_record set weight = " + weight
                            + ", waistline = " + waistline
                            + ", SBP = " + SBP
                            + ", DBP = " + DBP
                            + " where date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new SqlCommand("insert into daily_record(date, weight, waistline, SBP, DBP) values('"
                            + date.ToString("yyyy-MM-dd") + "', "
                            + weight + ", "
                            + waistline + ", "
                            + SBP + ", "
                            + DBP + ")", database);
                        command.ExecuteNonQuery();
                    }
                    command = new SqlCommand("delete from daily_diet where date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                    command.ExecuteNonQuery();
                    foreach (Diet d in diets)
                    {
                        command = new SqlCommand("insert into daily_diet(date, meal, diet, calorie) values('"
                            + date.ToString("yyyy-MM-dd") + "', "
                            + d.meal_id + ", N'"
                            + d.diet.Replace("'", "''") + "', "
                            + d.calorie + ")", database);
                        command.ExecuteNonQuery();
                    }

                    command = new SqlCommand("delete from daily_exercise where date = '" + date.ToString("yyyy-MM-dd") + "'", database);
                    command.ExecuteNonQuery();
                    foreach (Exercise e in exercises)
                    {
                        command = new SqlCommand("insert into daily_exercise(date, exercise_id) values('"
                            + date.ToString("yyyy-MM-dd") + "', "
                            + e.id + ")", database);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
                finally {
                    if (command != null) command.Dispose();
                }
            }
        }

        public void print()
        {
            Console.WriteLine("Weight: " + weight.ToString());
            Console.WriteLine("WasitLine: " + waistline.ToString());
            Console.WriteLine("SBP: " + SBP.ToString());
            Console.WriteLine("DBP: " + DBP.ToString());
            Console.WriteLine("BMI: " + BMI.ToString());
            Console.WriteLine("Today's Diets: ");
            foreach (Diet d in diets)
                Console.WriteLine("{0} {1} {2}", d.meal, d.diet, d.calorie.ToString());
            Console.WriteLine("Today's Exercises: ");
            foreach (Exercise e in exercises)
                Console.WriteLine("{0} {1} {2}", e.title, e.detail, e.calorie.ToString());
        }
    }
}
