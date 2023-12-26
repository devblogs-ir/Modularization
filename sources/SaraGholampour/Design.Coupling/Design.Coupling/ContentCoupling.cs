namespace Design.Coupling;

public class ContentCoupling
{

    public static void Main(string[] args)
    {
        Product product = new();
        
    
        product.totalBill(product.GetProducts());

    }
}
