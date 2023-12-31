namespace Coupling;

public class Stamp
{
  

// Modified DataRecord with additional fields
public class DataRecord
{
    public DataRecord(string name, int age, string address, string phoneNumber)
    {
        Name = name;
        Age = age;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; } // Additional field
    public string PhoneNumber { get; set; } // Additional field
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
    // Method to generate a report based on specific fields of the data
    public void GenerateReport(List<DataRecord> data)
    {
        Console.WriteLine("Report:");

        foreach (var record in data)
        {
            // Use only specific fields (Name and Age) from the shared data structure
            Console.WriteLine($"Name: {record.Name}, Age: {record.Age}");
        }
    }
}

/* Explain:
 In this example, DataRecord has additional fields (Address and PhoneNumber). 
 The ReportGenerator still only uses specific fields (Name and Age). 
 This represents stamp coupling, as not all fields in the shared data structure are utilized by each component
 */

}