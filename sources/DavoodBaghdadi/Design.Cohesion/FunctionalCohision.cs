namespace Design.Cohesion;

public class FunctionalCohision
{
    ICustomerRepository _customerRepository;

    IOrderRepository _orderRepository;  

    IEnumerable<Customer> GetDebtorCustomers()
    {
        return _customerRepository.GetAllCustomers().Where(c =>(c.credit- c.debit) < 0);
    }
    IEnumerable<Customer> GetFirstLevelCustomers()
    {
        return _orderRepository.GetAllOrders().GroupBy(o => o.CustomerId)
            .Select(group => new { Id = group.Key, NumberOfOrders = group.Count() })
            .Where(group => group.NumberOfOrders > 100 && group.NumberOfOrders < 500)
            .Select(group => new Customer { Id = group.Id });
    }
    IEnumerable<Customer> GetLoyalCustomers()
    {
        return _orderRepository.GetAllOrders().GroupBy(o => o.CustomerId)
            .Select(group => new { Id = group.Key, NumberOfOrders = group.Count() })
            .Where(group => group.NumberOfOrders > 500)
            .Select(group => new Customer { Id = group.Id });
    }
}
