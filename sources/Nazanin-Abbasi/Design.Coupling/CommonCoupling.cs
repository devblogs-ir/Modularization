namespace Design.Coupling.CommonCoupling;

/// <summary>
/// Common Coupling occurs when two or more modules share the same global data.
/// </summary>
public class CommonData
{
    public static int SharedValue = 0;
}

// Module 1
public class Module1
{
    public void UpdateSharedValue()
    {
        CommonData.SharedValue += 1;
    }

    public void DisplaySharedValue()
    {
        Console.WriteLine($"Module 1: SharedValue = {CommonData.SharedValue}");
    }
}

// Module 2
public class Module2
{
    public void UpdateSharedValue()
    {
        CommonData.SharedValue += 2;
    }

    public void DisplaySharedValue()
    {
        Console.WriteLine($"Module 2: SharedValue = {CommonData.SharedValue}");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Module1 and Module2
        Module1 module1 = new();
        Module2 module2 = new();

        // Update and display shared value in Module1
        module1.UpdateSharedValue();
        module1.DisplaySharedValue();

        // Update and display shared value in Module2
        module2.UpdateSharedValue();
        module2.DisplaySharedValue();
    }
}

