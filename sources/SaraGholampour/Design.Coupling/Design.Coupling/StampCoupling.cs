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
        return myBillItems.Sum(node => node.Price);
    }
}

public class StampCoupling
{
    public static void Main(string[] args)
    {
        Product product = new();
        
        Product[] storeProducts =
        {
            new Product("me before u", ECategory.Book, 150000, new User("Ali", 25, new DateOnly())),
            new Product("knife", ECategory.KitchenAppliances, 950000, new User("sasan", 25, new DateOnly())),
            new Product("doll", ECategory.Toy, 9630000, new User("samira", 30, new DateOnly()))
        };
        product.totalBill(storeProducts);

    }
}
