namespace Design.Cohesion
{
    public sealed class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
    }

    public enum TaskStatus : byte
    {
        ToDo = 1,
        InProgress = 2,
        Done = 3
    }

    public sealed class TaskManager
    {
        public void DetermineTaskStatus(List<Task> tasks)
        {
            var goingToDoTasks = GetGoingToDoTasks(tasks);

            var inProgressTasks = GetInProgressTasks(tasks);

            var doneTasks = GetDoneTasks(tasks);
        }

        private List<Task> GetGoingToDoTasks(List<Task> tasks)
        {
            return tasks.Where(_ => _.Status == TaskStatus.ToDo)
                .ToList();
        }

        private List<Task> GetInProgressTasks(List<Task> tasks)
        {
            return tasks.Where(_ => _.Status == TaskStatus.InProgress)
                .ToList();
        }

        private List<Task> GetDoneTasks(List<Task> tasks)
        {
            return tasks.Where(_ => _.Status == TaskStatus.Done)
                .ToList();
        }
    }
}
