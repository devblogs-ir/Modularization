namespace Cohesion;

public class Sequential
{
    
        // Method to read data from a file
        public string ReadDataFromFile(string filePath)
        {
            try
            {
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

        // Method to process the data
        public void ProcessData(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                Console.WriteLine($"Processing data: {data}");
                // Actual data processing logic would go here
            }
            else
            {
                Console.WriteLine("No data to process.");
            }
        }

        // Method to store the result in a database
        public void StoreDataInDatabase(string processedData)
        {
            if (!string.IsNullOrEmpty(processedData))
            {
                Console.WriteLine("Storing data in the database.");
                // Actual database storage logic would go here
            }
            else
            {
                Console.WriteLine("No processed data to store.");
            }
        }
    }
    /*Explain:
     In this example, the Sequential class exhibits sequential cohesion by providing methods that execute a sequence of steps: 
     reading data from a file, processing the data, and storing the result in a database
     */
