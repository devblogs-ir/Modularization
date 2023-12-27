namespace Coupling.function;
// Component A
class ComponentA
{
    public void PerformOperation()
    {
        // Performs some operation
    }
}

// Component B
class ComponentB
{
    private readonly ComponentA componentA;

    public ComponentB(ComponentA a)
    {
        componentA = a;
    }

    public void ProcessData()
    {
        // Process data
        componentA.PerformOperation();
        // Continue processing data
    }
}

// In this example, ComponentB depends on the behavior of ComponentA by calling its PerformOperation() method.
// for resolve we can use of DI (abstract and interface) and event-driven