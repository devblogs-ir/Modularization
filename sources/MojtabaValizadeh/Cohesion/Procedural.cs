namespace Cohesion;

public class Procedural
{
    // Method to check if a file exists
    public bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    // Method to create a new file
    public void CreateFile(string filePath)
    {
        try
        {
            File.Create(filePath);
            Console.WriteLine($"File created at: {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error creating file: {ex.Message}");
        }
    }

    // Method to write data to a file
    public void WriteToFile(string filePath, string data)
    {
        try
        {
            File.WriteAllText(filePath, data);
            Console.WriteLine($"Data written to file: {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }
}
/*Explain:
 In this example, the Procedural class exhibits procedural cohesion by grouping together methods that perform 
 file-related operations. 
 */