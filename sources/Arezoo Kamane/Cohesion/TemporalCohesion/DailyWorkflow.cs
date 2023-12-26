namespace Cohesion.TemporalCohesion
{
    public class DailyWorkFlow
    {
        public class DailyWorkflow
        {
            public void SendDailyEmail()
            {
                Console.WriteLine("Task: Send Daily Email");
            }

            public void PerformDailyBackup()
            {
                Console.WriteLine("Task: Perform Daily Backup");
            }
            public void ExecuteDailyWorkflow()
            {
                Console.WriteLine("Executing Daily Workflow:");
                SendDailyEmail();
                PerformDailyBackup();

                Console.WriteLine("Daily workflow executed successfully.\n");
            }
        }
    }
}
