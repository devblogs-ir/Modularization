namespace Design.Cohesion;

public class School
{
    private readonly List<Student> _students;
    private readonly List<Teacher> _teachers;

    public School(List<Student> students, List<Teacher> teachers)
    {
        _students = students;
        _teachers = teachers;
    }

    public List<Student> GetStudents()
    {
        return _students;
    }

    public List<Teacher> GetTeachers()
    {
        return _teachers;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        _teachers.Add(teacher);
    }
}

public class Student
{
    private readonly int _age;
    private readonly string _name;

    public Student(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age;
    }
}

public class Teacher
{
    private readonly string _name;
    private readonly string _subject;

    public Teacher(string name, string subject)
    {
        _name = name;
        _subject = subject;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetSubject()
    {
        return _subject;
    }
}