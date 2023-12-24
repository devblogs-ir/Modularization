namespace Coupling.TemporalCoupling;

// Component A
class ComponentA
{
    public void PrepareData()
    {
        // Prepare data logic
    }

    public void ProcessData()
    {
        // Process data logic
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

    public void PerformOperation()
    {
        componentA.PrepareData();
        // ... additional operations ...
        componentA.ProcessData();
    }
}

// In this example, ComponentB relies on ComponentA and assumes that PrepareData() should be called before 
// ProcessData() in PerformOperation(). If the order of method calls changes or additional operations are introduced 
// between the calls, the correct operation of ComponentB may be affected.