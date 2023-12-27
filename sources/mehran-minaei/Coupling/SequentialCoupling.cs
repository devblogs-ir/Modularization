namespace Coupling.SequentialCoupling;

// Component A
class ComponentA
{
    public void Step1()
    {
        // Step 1 logic
    }

    public void Step2()
    {
        // Step 2 logic
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
        componentA.Step1();
        componentA.Step2();
    }
}

// In this example, ComponentB depends on ComponentA and assumes that Step1() should be executed before Step2() 
// in PerformOperation(). If the order of execution changes or additional steps are introduced in ComponentA,
// ComponentB needs to be modified accordingly.
