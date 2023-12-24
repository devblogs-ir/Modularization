
namespace Cohesion;
 public class ProceduralCohesion {

    public bool OpenApp() { }
    public IEnumerable GetApplicationElements() { 

    }

    public bool SendPostMessageEvent() { 

    }
 }

public class Program
{
    static void Main(string[] args)
    {
        ProceduralCohesion proceduralCohesion = new ();

        proceduralCohesion.OpenApp();
        proceduralCohesion.GetApplicationElements();
        proceduralCohesion.SendPostMessageEvent();
    }
}
 // this example has ben showing that all function are called at or near the same time.
 // if there are not executed in order, the problem will crash