namespace Design.Cohesion.FunctionalCohesion;

/// <summary>
/// Functional cohesion: This type of cohesion occurs when all elements in a module contribute to a single well-defined business function or purpose, and there is little or no coupling with other modules.
/// The goal of this module is to show the result of adding two numbers.
/// This code demonstrates Functional Cohesion in which there is three seperate classes which has single responsibity to do.
/// </summary>
public class FunctionalCohesion
{
    public class Sum
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Window
    {
        public void DisplayResult(int result)
        {
            Console.WriteLine(result);
        }
    }

    public class Driver
    {
        public void Run()
        {
            Sum sum = new();
            Window window = new();
            int result = sum.Add(2, 3);
            window.DisplayResult(result);
        }
    }
}
