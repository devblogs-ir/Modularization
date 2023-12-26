using System.Reflection.Emit;

namespace Design.Coupling;

public enum ECategory
{
    Stationery,
    Toy,
    HomeAppliances,
    KitchenAppliances,
    Clothing,
    Beauty,
    Tools,
    Book
}

public class Product
{
    public string Title { get; set; }
    public ECategory Category { get; set; }
    public uint Price { get; set; }
    public User Seller { get; set; }
    public Guid GuId { get; set; }
    public static ushort TaxPercentage { get; set; } = 9;

    public Product()
    {
    }

    public Product(string title, ECategory category, uint price, User seller)
    {
        Title = title;
        Category = category;
        Price = price;
        Seller = seller;
        GuId = Guid.NewGuid();
    }

    public long totalBill(Product[] myBillItems)
    {
        var sum= myBillItems.Sum(node => node.Price);
        return sum + (9 * sum / 100);
    }
    public Product[] GetProducts()
    {
        Product[] storeProducts =
        {
            new Product("me before u", ECategory.Book, 1000, new User("Ali", 25, new DateOnly(),null)),
            new Product("knife", ECategory.KitchenAppliances, 4000, new User("sasan", 25, new DateOnly(),null)),
            new Product("doll", ECategory.Toy, 5000, new User("samira", 30, new DateOnly(),null))
        };
        return storeProducts;

    }
}


public class StampCoupling
{
    public static void Main(string[] args)
    {
        Product product = new();
        
      
        product.totalBill(product.GetProducts());

    }
}
