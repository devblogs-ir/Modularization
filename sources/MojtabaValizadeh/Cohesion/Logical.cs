namespace Cohesion;

public class Logical
{
    public int? Calculator(Operation operation, int a, int b)
    {
        switch (operation)
        {
            case Operation.Add:
                return a + b;
            case Operation.Multiply:
                return a * b;
            case Operation.Subtract:
                return a - b;
            default:

                return null;
        }
    }

    public enum Operation : byte
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3
    }
    /*Explain:
     In this example, the Calculator Method exhibits logical cohesion by grouping methods that perform various arithmetic calculations
     */
}