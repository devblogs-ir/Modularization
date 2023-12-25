namespace Design.Coupling
{
    public sealed class ProductService
    {
        public void Insert(string title, string description)
        {
            // inserting product into Db
        }
    }

    public sealed class ProductController
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public void Post(string title, string description)
        {
            _productService.Insert(title, description);
        }
    }
}
