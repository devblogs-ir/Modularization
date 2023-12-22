namespace Coupling;

public class Temporal
{
    public class DataLoader
    {
        public void LoadData()
        {
            Console.WriteLine("Data loaded from external source.");
        }
    }

// DataProcessor class that processes data
    public class DataProcessor
    {
        // Temporal coupling: Assumes that LoadData is called before ProcessData
        public void ProcessData()
        {
            Console.WriteLine("Data processed.");
        }
    }
    /*Explain:
     In this example, the dataLoader class assumes that LoadData is called before processData.
      If the order of method calls is changed, the behavior may not be as expected
     */
}