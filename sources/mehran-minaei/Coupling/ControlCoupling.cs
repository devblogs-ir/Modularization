namespace Coupling;

class ComponentControlA
{
    private ComponentControlB componentControlB;

    public ComponentControlA(ComponentControlB b)
    {
        componentControlB = b;
    }

    public void DoSomething()
    {
        // Code specific to Component A

        if (componentControlB.IsEnabled())
        {
            componentControlB.DoSomethingElse();
        }
    }
}

// Component B
class ComponentControlB
{
    private bool isEnabled;

    public ComponentControlB()
    {
        isEnabled = true;
    }

    public void DoSomethingElse()
    {
        // Code specific to Component B
    }

    public bool IsEnabled()
    {
        return isEnabled;
    }
}

// in this example class A control execution of class B 
// for resolve this coupling we can use of event-driven pattern