//in this code Car class Control the Flow of Engine Class by calling its start() Method.
public class Car
{
    private readonly Engine _engine;
    public Car(Engine engine)
    {
        _engine=engine;
    }
    public void Start()
    {
        _engine.Start();
    }
}
public class Engine
{
   public void Start()
   {
    Console.WriteLine("Engine Started!!!");
   }
}