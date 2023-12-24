namespace Design.Coupling.StampCoupling;

/// <summary>
/// Stamp Coupling occurs when two modules share a composite data structure, but only use part of it.
/// The EmployeeRepository class shares a composite data structure (Employee) with the Employee class, but only uses part of it (Name). 
/// </summary>
public class Employee
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
}

public class EmployeeRepository
{
    private readonly List<Employee> _employees;

    public EmployeeRepository()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public List<string?> GetEmployeeNames()
    {
        return _employees.Select(e => e.Name).ToList();
    }
}