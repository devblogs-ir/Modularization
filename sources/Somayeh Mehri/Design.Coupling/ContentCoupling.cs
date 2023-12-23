namespace Design.Coupling
{
    class Buyer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string NationalCode { get; set; }
        public int PurchaseCount { get; set; }
    }

    class BuyerService
    {
        public IEnumerable<Buyer> GetActiveBuyers()
        {
            return Enumerable.Empty<Buyer>().Where(x => x.PurchaseCount > 10);
        }
    }

    class GiftGenerator
    {
        private readonly BuyerService _buyerService;

        public GiftGenerator(BuyerService buyerService)
        {
            _buyerService = buyerService;
        }

       void Generate()
        {
            var buyer = _buyerService.GetActiveBuyers();
            foreach (var item in buyer)
            {
                //active discount code
            }
        }
    }
}
