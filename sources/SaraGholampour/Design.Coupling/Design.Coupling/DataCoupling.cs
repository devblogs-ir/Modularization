namespace Design.Coupling;


public class Student : User
{
    public string Grade { get; set; }

    public Student(string name, byte age, string grade) : base(name, age)
    {
        Grade = grade;
    }
}



public class DataCoupling
{
    private Student sara = new Student("sara", 20, "3");
}
