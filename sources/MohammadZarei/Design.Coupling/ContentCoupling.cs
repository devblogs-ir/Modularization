namespace Design.Coupling
{
    public sealed class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public decimal TotalBalance { get; set; }

    }

    public sealed class DataStore
    {
        public static List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Id = Guid.NewGuid(), FirstName = "ali", TotalBalance = 0 },
                new Customer() { Id = Guid.NewGuid(), FirstName = "babak", TotalBalance = 100 },
                new Customer() { Id = Guid.NewGuid(), FirstName = "sina", TotalBalance = 520 },
            };
        }
    }

    public sealed class CustomerService
    {
        public void IncreaseBalance(Guid customerId, decimal balance)
        {
            var babak = DataStore.GetCustomers()
                .Where(_ => _.Id == customerId)
                .SingleOrDefault();

            babak.TotalBalance += balance;
        }
    }
}
