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
    public Order(Customer customer,decimal totalAmount)
    {
        _customer=customer;
        _amount=totalAmount;

    }

    public Customer GetCustumer()
    {
        return _customer;
    }

}