namespace Cohesion;

public class OrderSystem { 

}

public class ProductSystem {

 }

public class InventorySystem { 

}


 public class TemporalCohesion {

    public void OrderInit() { }
    public void ProductInit() { }
    public void InventoryInit() { }
 }

public class Program
{
    static void Main(string[] args)
    {
        TemporalCohesion temporalCohesion = new ();

        temporalCohesion.OrderInit();
        temporalCohesion.ProductInit();
        temporalCohesion.InventoryInit();

        // resolve
        delegate void OperationDelegate();
        OperationDelegate operationDelegate;
        operationDelegate = OrderInitDelegate;
        operationDelegate += ProductInitDelegate;
        operationDelegate += InventoryInitDelegate;
        operationDelegate();

        void OrderInitDelegate()
        {
            Console.WriteLine("OrderInitDelegate");
        }
        void ProductInitDelegate()
        {
            Console.WriteLine("ProductInitDelegate");
        }
        void InventoryInitDelegate()
        {
            Console.WriteLine("InventoryInitDelegate");
        }

    }
}
 // this example has ben showing that all init implement in the a module.
 // so for improve it, we can define a delegates and performs similar operations grouped together


 