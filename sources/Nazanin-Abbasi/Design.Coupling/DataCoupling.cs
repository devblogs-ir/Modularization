namespace Design.Coupling.DataCoupling;

/// <summary>
/// Data Coupling occurs when two modules interact using an elementary data item that is passed as method parameters between them.
/// Here’s an example of a simple calculator implemented that demonstrates Data Coupling.
/// In this example, the Calculator class interacts with two integer values (num1 and num2) that are passed as method parameters between the modules.
/// </summary>
public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}