namespace Design.Cohesion
{
    public sealed class TaskScheduler
    {
        public void ScheduleTask(ScheduleTaskDto dto)
        {
            AllocateResources(dto.Title, dto.Duration);
            ExecuteTask(dto.Title);
            LogTaskCompletion(dto.Title, dto.StartTime, dto.Duration);
        }

        private void AllocateResources(string taskName, TimeSpan duration)
        {
            Console.WriteLine($"Resources allocated for task {taskName} " +
                $"(Duration: {duration}).");
        }

        private void ExecuteTask(string taskName)
        {
            Console.WriteLine($"Executing task: {taskName}");
        }

        private void LogTaskCompletion(
            string title,
            DateTime startTime,
            TimeSpan duration)
        {
            Console.WriteLine($"Task {title} started at: {startTime} and" +
                $"finished at: {startTime.Add(duration)}.");
        }
    }

    public sealed class ScheduleTaskDto
    {
        public required string Title { get; init; }
        public required DateTime StartTime { get; init; }
        public required TimeSpan Duration { get; init; }
    }
}
