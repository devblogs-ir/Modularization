namespace Cohesion;


public readonly record struct Lessons (string Name, bool isActive );


public class CoincidentalCohesion
{
    private Lessons[] LessonList = [new Lessons("Lesson-A", true), new Lessons("Lesson-B", false)]; 
    public bool SetStudentStatus() { 

    }

    public bool DeleteTeacher() { }

    public Lessons[] GetLessonList() {
        return LessonList;
    }
}

// There are some Function that not related together, so wwe have worst cohesion