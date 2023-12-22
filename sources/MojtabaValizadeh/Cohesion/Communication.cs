namespace Cohesion;

public class Communication
{
    private string _inputData;

    // Method to set input data
    public void SetInputData(string data)
    {
        _inputData = data;
    }

    // Method to process the input data
    public void ProcessData()
    {
        if (!string.IsNullOrEmpty(_inputData))
        {
            Console.WriteLine($"Processing data: {_inputData}");
            // Actual data processing logic would go here
        }
        else
        {
            Console.WriteLine("No data to process.");
        }
    }

    // Method to get the processed data
    public string GetProcessedData()
    {
        // Communication cohesion: Returns the processed data
        return $"Processed data: {_inputData.ToUpper()}";
    }
}
/*Explain:
 In this example, the Communication class exhibits communication cohesion by sharing data among its methods.
 */