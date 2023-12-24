namespace Design.Cohesion.CoincidentalCohesion;

/// <summary>
/// Coincidental Cohesion occurs when entirely unrelated abstractions are thrown into the same class or module.
/// </summary>
public class CoincidentalCohesionModule
{
    // Method 1: Performs a mathematical operation
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Method 2: Prints a message to the console
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Method 3: Reads input from the user
    public string? ReadInput()
    {
        Console.Write("Enter some input: ");
        return Console.ReadLine();
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create an instance of the module
        CoincidentalCohesionModule module = new();

        // Use methods of the module, which have no meaningful relationship
        int sum = module.AddNumbers(5, 7);
        Console.WriteLine($"Sum: {sum}");

        module.PrintMessage("Hello, coincidental cohesion!");

        string? userInput = module.ReadInput();
        Console.WriteLine($"User Input: {userInput}");
    }
}
