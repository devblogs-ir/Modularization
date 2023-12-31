
namespace Design.Coupling;
public class ContentCoupling
{
    StudentAgeCalculator studentAgeCalculator = new ();
    TestStudent user1 = new() { Age = 123};
    TestStudent user2 = new() { Age = 123};

    public void CalculatTotalAge()
    {
        studentAgeCalculator.Add(user1);
        studentAgeCalculator.Add(user2);
        studentAgeCalculator.TotalAge();
    }
}

public class TestStudent
{
    public decimal Age { get; set; }

}
public class StudentAgeCalculator
{
    private List<TestStudent> students;
    public StudentAgeCalculator()
    {
        students = new List<TestStudent>();
    }
    public void Add(TestStudent model)
    {
        students.Add(model);
    }
    public decimal TotalAge()
    {
        decimal resualt = 0;
        foreach (var product in students)
        {
            resualt += product.Age;
        }
        return resualt;
    }
}