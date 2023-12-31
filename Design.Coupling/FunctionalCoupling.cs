
using Dumpify;

namespace Design.Coupling;

public class FunctionalCoupling
{
    public void Main()
    {
        Providers providers = new Providers();
        providers.SMSPeovider("Arvin");
        providers.EmailProvider("test");
    }
}

public class Providers
{ 
    public string EmailProvider(string reciver)
    {
        return $"Send Email to {reciver}";
    }
    public string SMSPeovider(string reciver)
    {
        return $"Send SMS to {reciver}";
    }
}
