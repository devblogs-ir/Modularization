namespace Design.Cohesion;

public class Logical
{
    public class Product
    {
        private string Title { get; set; }
        private ulong Price { get; set; }
        private uint Weight { get; set; }


        private Product(string title, ulong price, uint weight)
        {
            Title = title;
            Price = price;
            Weight = weight;
        }

        public Product SetProduct(string title, ulong price, uint weight)
        {
            return new Product("Book", 30000, 10);
        }
    }

    public class TaxiService
    {
        public string Car { get; set; }
        public string Plaque { get; set; }

        public TaxiService(string car, string plaque)
        {
            Car = car;
            Plaque = plaque;
        }
    }
}
