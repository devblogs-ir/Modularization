﻿using Dumpify;

namespace Design.Cohesion;

public class NoCoupling
{
    public bool CarDeliveryWithCrane()
    {
        "The car was delivered with a crane".Dump();
        return true;
    }

    public bool DirectDeliveryCar()
    {
        "The car was delivered direct".Dump();
        return true;
    }
}
