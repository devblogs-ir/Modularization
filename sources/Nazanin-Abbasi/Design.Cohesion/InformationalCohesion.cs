namespace Design.Cohesion.InformationalCohesion;

/// <summary>
/// Informational cohesion is a type of cohesion where elements or tasks are grouped together in a module based on the information they share.
/// Data analysis often involves grouping together elements that are related to a specific type of data or analysis.
/// </summary>
public class InformationalCohesion
{
    public void AnalyzeCustomerData(Dictionary<string, object> customerData)
    {
        // Analyze customer data logic
        int age = (int)customerData["age"];
        string gender = (string)customerData["gender"];
        string location = (string)customerData["location"];
        Console.WriteLine("Customer data analyzed successfully");
    }

    public void AnalyzeSalesData(Dictionary<string, object> salesData)
    {
        // Analyze sales data logic
        int revenue = (int)salesData["revenue"];
        int expenses = (int)salesData["expenses"];
        int profit = revenue - expenses;
        Console.WriteLine("Sales data analyzed successfully");
    }

    public void AnalyzeBehaviorData(Dictionary<string, object> behaviorData)
    {
        // Analyze behavior data logic
        string[] interests = (string[])behaviorData["interests"];
        string[] purchases = (string[])behaviorData["purchases"];
        Console.WriteLine("Behavior data analyzed successfully");
    }
}