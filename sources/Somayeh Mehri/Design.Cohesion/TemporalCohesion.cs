namespace Design.Cohesion
{
    file class UserService
    {
        public void InsertUser() { }
        public void UpdateUser() { }
        public void GenerateReportActiveUserWeekly(DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                //Report
            }
        }
    }
}
