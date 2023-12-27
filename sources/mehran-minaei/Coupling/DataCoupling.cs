namespace Coupling;

// Component A
class ComponentDataA
{
    public int CalculateSum(int x, int y)
    {
        // Code specific to Component A

        return x + y;
    }
}

// Component B
class ComponentDataB
{
    private ComponentDataA componentA;

    public ComponentDataB(ComponentDataA a)
    {
        componentA = a;
    }

    public void ProcessData(int num1, int num2)
    {
        // Code specific to Component B

        int sum = componentA.CalculateSum(num1, num2);
        Console.WriteLine("The sum is: " + sum);
    }
}


// In this example, ComponentB depends on ComponentA to perform a calculation.
// to resolve of this problem we can use of interface