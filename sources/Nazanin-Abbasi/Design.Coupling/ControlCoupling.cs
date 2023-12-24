namespace Design.Coupling.ControlCoupling;

/// <summary>
/// Control Coupling occurs when one module controls the flow of another module by passing it information on what to do next.
/// In this example, the Car class is dependent on the TrafficLight class to control the flow of traffic.
/// </summary>
public class TrafficLight
{
    public void Stop()
    {
        Console.WriteLine("The traffic light is red.");
    }

    public void Go()
    {
        Console.WriteLine("The traffic light is green.");
    }
}

public class Car
{
    private readonly TrafficLight _trafficLight;

    public Car(TrafficLight trafficLight)
    {
        _trafficLight = trafficLight;
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
        _trafficLight.Go();
    }

    public void Stop()
    {
        Console.WriteLine("The car is stopping.");
        _trafficLight.Stop();
    }
}