namespace Design.Coupling.ContentCoupling;

/// <summary>
/// Content Coupling occurs when one module depends on the internal workings of another module.
/// </summary>

// Module 1
public class Module1
{
    public void PerformAction()
    {
        Console.WriteLine("Module 1 performing an action.");
    }
}

// Module 2
public class Module2
{
    // Module 2 has a method that depends on the internal details of Module 1
    public void UseModule1(Module1 module1)
    {
        Console.WriteLine("Module 2 is using Module 1.");
        module1.PerformAction();
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create instances of Module1 and Module2
        Module1 module1 = new();
        Module2 module2 = new();

        // Module2 uses Module1 directly, demonstrating content coupling
        module2.UseModule1(module1);
    }
}