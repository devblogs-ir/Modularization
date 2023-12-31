namespace Coupling;

public class Common
{
    public class SharedData
    {
        public static int Counter { get; set; }
    }

// dataProcessor module that modifies the shared data
    public class DataProcessor
    {
        public void ProcessData()
        {
            // Increment the shared counter
            SharedData.Counter++;

            Console.WriteLine($"Data processed. Counter: {SharedData.Counter}");
        }
    }

    // dataLogger module that logs information based on the shared data
    public class DataLogger
    {
        public void LogData()
        {
            // Log information based on the shared counter
            Console.WriteLine($"Data logged. Counter: {SharedData.Counter}");
        }
    }
    /*Explain
     In this example, dataProcessor increments a shared counter in the share Data class,
      and dataLogger logs information based on the value of the shared counter.
       both modules are directly dependent on the shared global data (sharedData.Counter).
        If the  sharedData changes, it can impact both dataProcessor and dataLogger
     */
}