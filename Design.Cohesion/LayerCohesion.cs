
using Dumpify;

namespace Design.Cohesion;
public class LayerCohesion
{
}

public class InfrastructurePersistanceLayer
{
    public void ApplicationDbContext()
    {
        "Connect to db".Dump();
    }
    public void SmsProvider()
    {
        "Connect to sms service".Dump();
    }
}
public class ApplicationLayer
{
    private InfrastructurePersistanceLayer _context;
    public ApplicationLayer()
    {
        _context = new InfrastructurePersistanceLayer();
    }
    public void AddUser()
    {
        _context.ApplicationDbContext();
        //Add user
    }
}


public class PresentationLayer
{
    private ApplicationLayer _service;
    public PresentationLayer()
    {
        _service = new ApplicationLayer();
    }
    public void UserController()
    {
        _service.AddUser();
    }
}