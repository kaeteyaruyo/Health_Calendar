namespace Health_Calendar
{
    class Exercise
    {
        public string title;
        public string detail;
        public int id;
        public int timeLength;
        public int calorie;

        public Exercise(int id, string title, string detail, int timeLength, int calorie)
        {
            this.id = id;
            this.title = title;
            this.detail = detail;
            this.timeLength = timeLength;
            this.calorie = calorie;
        }
    }
}
