public interface ICongratsService
{
    void Congratulations();
}

public class YaldaCongrats : ICongratsService
{
    public void Congratulations()
    {
        //Yalda Logic Here
    }
}

public class NoruzCongrats : ICongratsService
{
    public void Congratulations()
    {
        //Noruz Logic Here
    }
}

public class CongratsController
{
    private ICongratsService _service;
    public CongratsController(ICongratsService service)
    {
        _service = service;
    }

    public void InvokeService()
    {
        _service.Congratulations();
    }
}

public class IOC
{
    public CongratsController CreateYaldaService()
    {
        ICongratsService yalda = new YaldaCongrats();

        CongratsController congrats = new (yalda);

        return congrats;
    }

    public CongratsController CreateNoruzService()
    {
        ICongratsService noruz = new NoruzCongrats();

        CongratsController congrats = new (noruz);
        
        return congrats;
    }
}

// Example :
// IOC inject = new ();
// CongratsController yaldaCongrats = inject.CreateYaldaService();
// CongratsController noruzCongrats = inject.CreateNoruzService();
// yaldaCongrats.InvokeService();
// noruzCongrats.InvokeService();