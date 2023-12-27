namespace Coupling;

// Component A
class ComponentA
{
    private ComponentB componentB;

    public ComponentA()
    {
        componentB = new ComponentB();
    }

    public void DoSomething()
    {
        // Code specific to Component A

        componentB.DoSomethingElse();
    }
}

// Component B
class ComponentB
{
    public void DoSomethingElse()
    {
        // Code specific to Component B
    }
}

