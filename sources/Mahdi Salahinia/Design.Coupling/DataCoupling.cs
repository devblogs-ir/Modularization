using Dumpify;

namespace Design.Coupling;

public class DataCoupling
{
    
}

public class CarDeliveryNotification
{
    public void CarDeliveryWithCrane(string name, string craneDetail)
    {
        $"Dear {name} your car with {craneDetail} is on the way...".Dump();
    }
}

public class CarDeliveryController
{
    private readonly CarDeliveryNotification _notification;

    public void PostDeliveryInfo()
    {
        _notification.CarDeliveryWithCrane("Mahdi", "Black Crane");
    }
}
