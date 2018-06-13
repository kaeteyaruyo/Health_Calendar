namespace Health_Calendar
{
    class Diet
    {
        public string meal;
        public string diet;
        public int calorie;
        public int meal_id;

        public Diet(int meal, string diet, int calorie)
        {
            this.meal_id = meal;
            if (meal == 1) this.meal = "早餐";
            else if (meal == 2) this.meal = "午餐";
            else if (meal == 3) this.meal = "晚餐";
            else if (meal == 4) this.meal = "其他";
            this.diet = diet;
            this.calorie = calorie;
        }
    }
}
