namespace Coupling.DataStructuer;

// Component A
class ComponentA
{
    private int[] sharedData;

    public ComponentA(int[] data)
    {
        sharedData = data;
    }

    public void ProcessData()
    {
        // Access and manipulate shared data
        for (int i = 0; i < sharedData.Length; i++)
        {
            sharedData[i] *= 2;
        }
    }
}

// Component B
class ComponentB
{
    private int[] sharedData;

    public ComponentB(int[] data)
    {
        sharedData = data;
    }

    public void PrintData()
    {
        // Access and use shared data
        for (int i = 0; i < sharedData.Length; i++)
        {
            Console.WriteLine(sharedData[i]);
        }
    }
}

// like common coupling depended to share data