namespace Coupling;
// Component A
class ComponentContentA
{
    public void DoSomething()
    {
        // Code specific to Component A

        ComponentContentB componentB = new ComponentContentB();
        componentB.DoSomethingElse();
    }
}

// Component B
class ComponentContentB
{
    public void DoSomethingElse()
    {
        // Code specific to Component B
    }
}


// in this example, ComponentA directly creates an instance of ComponentB within its DoSomething method and calls 
// its DoSomethingElse method. This creates a content coupling because ComponentA has knowledge of and relies on the
// internal details and implementation of ComponentB.