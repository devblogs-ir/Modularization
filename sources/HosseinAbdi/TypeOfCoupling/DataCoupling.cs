using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private int _age;
    private string _name;
    public Customer(string name,int age)
    {
        _age=age;
        _name=name;

    }
}

public class Order
{
    private Customer _customer;
    private decimal _amount;
    public Order(Customer customer,decimal amount)
    {
        _customer=customer;
        _amount=amount;

    }

    public Customer GetCustomer()
    {
        return _customer;
    }

}