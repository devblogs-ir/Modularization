namespace Coupling;

public class Control
{
    public class MathOperation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        
    }

// calculator class that uses mathOperation and has control coupling
    public class Calculator
    {

        public int PerformOperation(int a, int b, string operation)
        {
            int result = 0;

            // control coupling: The calculator class relies on the operation string to determine which method to call
            switch (operation)
            {
                case "Add":
                    result = MathOperation.Add(a, b);
                    break;
                case "Subtract":
                    result = MathOperation.Subtract(a, b);
                    break;
                // additional cases for other operations can be added in the future
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            return result;
        }
    }
/*Explain
 In this example, the calculator class has control coupling with the mathOperation class 
 because it relies on a string parameter (operation) to determine which mathematical operation to perform.
 */
}