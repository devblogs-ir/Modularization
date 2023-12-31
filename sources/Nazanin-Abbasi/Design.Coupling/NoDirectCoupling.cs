namespace Design.Coupling.NoDirectCoupling;

/// <summary>
/// Here’s an example of how a car and wheel can be implemented to demonstrate no direct.
/// In this example, the Car class is dependent on the IWheel interface rather than the Wheel class itself. 
/// This allows the Car class to operate independently of the Wheel class, which is essential for the car’s functionality. 
/// The Wheel class implements the IWheel interface, which allows it to be used by the Car class
/// </summary>
public interface IWheel
{
    void Rotate();
}

public class Wheel : IWheel
{
    public void Rotate()
    {
        Console.WriteLine("The wheel is rotating.");
    }
}

public class Car
{
    private readonly IWheel _wheel;

    public Car(IWheel wheel)
    {
        _wheel = wheel;
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
        _wheel.Rotate();
    }
}