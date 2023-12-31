namespace Coupling;

public class Content
{
    public class DataProcessor
    {
        private  List<int> _data = new();

        // Method to add data to the internal list
        public void AddData(int value)
        {
            // content coupling: dataProvider relies on the internal implementation details of dataProcessor
            _data.Add(value);
        }

        // Method to process the data
        public void ProcessData()
        {
            // actual data processing logic would go here
            Console.WriteLine("Data processed.");
        }
    }

// dataProvider class that directly manipulates the internal data of dataProcessor
    public class DataProvider
    {
        private DataProcessor dataProcessor;

        public DataProvider(DataProcessor dataProcessor)
        {
            this.dataProcessor = dataProcessor;
        }

        // Content coupling: DataProvider relies on the internal implementation details of dataProcessor
        public void ProvideDataAndProcess()
        {
            // Provide data to DataProcessor and run data processing
            dataProcessor.AddData(42);
            dataProcessor.ProcessData();
        }
    }
}