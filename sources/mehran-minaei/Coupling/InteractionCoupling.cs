namespace Coupling.Interaction;

// Component A
class ComponentA
{
    public void ProcessData(string data)
    {
        // Process the data
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
        string data = "Some data";
        componentA.ProcessData(data);
    }
}

// In this example, ComponentB depends on the ComponentA class and its ProcessData() method. If the method signature 
// or behavior of ProcessData() changes in ComponentA, it can break the functionality of ComponentB, requiring 
// modifications to ComponentB as well.