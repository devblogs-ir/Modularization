namespace Coupling;

public class Data
{
// Data class representing information stored by the DataManager
    public class DataRecord
    {

        public string Name { get; set; }
        public int Age { get; set; }
    }

// DataManager class responsible for storing and retrieving data
    public class DataManager
    {
        private readonly List<DataRecord> _data = new ();

        // Method to add data to the DataManager
        public void AddData(DataRecord record)
        {
            _data.Add(record);
        }

        // Method to retrieve all data from the DataManager
        public List<DataRecord> GetAllData()
        {
            return new List<DataRecord>(_data);
        }
    }

// ReportGenerator class that generates reports based on data
    public class ReportGenerator
    {
        // Method to generate a report based on data
        public void GenerateReport(List<DataRecord> data)
        {
            Console.WriteLine("Report:");

            foreach (var record in data)
            {
                Console.WriteLine($"Name: {record.Name}, Age: {record.Age}");
            }
        }
    }
    
    /*Explain:
    In this example, the ReportGenerator class is data-coupled to the DataManager class. 
    It depends on the DataRecord structure provided by the DataManager
     but doesn't need to know how the data is stored or managed internally by the DataManager. 
     */
}
