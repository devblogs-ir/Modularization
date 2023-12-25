namespace Design.Coupling;


public class Student : User
{
    public string Grade { get; set; }

    public Student(string name, byte age, string grade,DateOnly birthDate) : base(name, age,birthDate)
    {
        Grade = grade;
    }
}



public class DataCoupling
{
    static void Main(string[] args)
    {
        Student sara = new Student("sara", 20, "3",new DateOnly(2000, 10, 21));
    }
}
