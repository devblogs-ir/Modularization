using Dumpify;

namespace Design.Coupling;

/// <summary>
/// Car class depend specific engine,Transmission , if engine change my class dose not work!
/// </summary>
public class Car
{
    private readonly Engine _engine;
    private readonly Transmission _transmission;

    public Car()
    {
        _engine = new Engine();
        _transmission = new Transmission();
    }

    public void Start()
    {
        _engine.Start();
        _transmission.ShiftUp();
    }

    public void Stop()
    {
        _transmission.ShiftDown();
        _engine.Stop();
    }
}

public class Engine
{
    public void Start()
    {
        "Engine started.".Dump();
    }

    public void Stop()
    {
        "Engine stopped.".Dump();
    }
}

public class Transmission
{
    private readonly Engine _engine;

    public Transmission()
    {
        _engine = new Engine();
    }

    public void ShiftUp()
    {
        "Transmission shifted up.".Dump();
        _engine.Start();
    }

    public void ShiftDown()
    {
        "Transmission shifted down.".Dump();
        _engine.Stop();
    }
}