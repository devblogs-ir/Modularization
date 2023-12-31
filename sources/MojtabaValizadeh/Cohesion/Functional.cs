namespace Cohesion;

public class Functional
{
    // Method for addition
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method for subtraction
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Method for multiplication
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method for division
    public double Divide(int a, int b)
    {
        // Check for division by zero
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN; // Not a Number
        }

        return (double)a / b;
    }

    /*Explain:
     In this example, the Functional class demonstrates functional cohesion by grouping methods
      that perform specific mathematical operations.
       Each method is focused on a single functionality (addition, subtraction, multiplication, and division). 
     */
}