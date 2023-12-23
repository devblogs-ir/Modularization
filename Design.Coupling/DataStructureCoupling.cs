using Dumpify;
using System.Data;

namespace Design.Coupling;

public class DataStructureCoupling
{
    Customer TestCustomer = new() { Name = "Test" };
    Course TestCourse = new() { Name = "TestCourse", Price = 123 };
    public void SetOrder()
    {
        Orders orders = new Orders();
        orders.SetOrder(TestCustomer, TestCourse);
    }
}

public class Customer
{
    public string Name { get; set; }
}
public class Course
{
    public decimal Price { get; set; }
    public string Name { get; set; }
}

public class Orders
{
    public void SetOrder(Customer customer , Course course)
    {
        $"user {customer.Name} your order {course.Name} you have to pay {course.Price}".Dump();
    }
}

