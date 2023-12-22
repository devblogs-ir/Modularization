namespace Coupling;

public class External
{
    public class FileReader
    {
        public string ReadDataFromFile(string filePath)
        {
            try
            {
                // external coupling: FileReader depends on the external file system
                return File.ReadAllText(filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
                return string.Empty;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return string.Empty;
            }
        }
    }

// dataProcessor class that processes data obtained from an external source
    public class DataProcessor
    {
        public void ProcessData(string data)
        {
            // external coupling: dataProcessor depends on the format of the external data
            if (!string.IsNullOrEmpty(data))
            {
                Console.WriteLine($"Processing data: {data}");
                
            }
            else
            {
                Console.WriteLine("No data to process.");
            }
        }
    }
    /*Explain:
     In this example, the FileReader class has external coupling because it depends on the external file system.
     */
}