namespace Cohesion;

public class Temporal
{
    // Methods representing individual tasks
    private void PerformTask1()
    {
        Console.WriteLine("Task 1: Initializing...");
        Thread.Sleep(2000); // Simulate task execution time
        Console.WriteLine("Task 1 completed.");
    }

    private void PerformTask2()
    {
        Console.WriteLine("Task 2: Processing...");
        Thread.Sleep(3000); // Simulate task execution time
        Console.WriteLine("Task 2 completed.");
    }

    private void PerformTask3()
    {
        Console.WriteLine("Task 3: Finalizing...");
        Thread.Sleep(1500); // Simulate task execution time
        Console.WriteLine("Task 3 completed.");
    }

    // Method to start a series of tasks
    public void StartTasks()
    {
        Console.WriteLine("Starting tasks...");

        // Temporal cohesion: Methods are called in a specific sequence
        PerformTask1();
        PerformTask2();
        PerformTask3();

        Console.WriteLine("Tasks completed.");
    }
}
/*Explain:
 In this example, the Temporal class exhibits temporal cohesion
  by organizing its methods in a specific sequence within the StartTasks method. 
 */