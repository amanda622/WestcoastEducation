namespace WestcoastEducation.Models;

public class School
{
    //aggregation
    public List<Course> Courses { get; set; } = [];
    public List<Student> Students { get; set; } = [];
    public List<Teacher> Teachers {get; set;} = [];

    public void AddCourse(Course course)
    {
        foreach (var item in Courses)
        {
            if (item.CourseNumber == course.CourseNumber)
            {
                Console.WriteLine("Kursen finns redan.");
                return;
            }
        }
        Courses.Add(course);
    }
    public void ListCourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine("Inga kurser.");
        }
        foreach (var item in Courses)
        {
            Console.WriteLine(item);
        }
    }

    public void AddStudent(Student student)
    {
        foreach(var item in Students)
        {
            if(item.PersonNumber == student.PersonNumber)
            {
                Console.WriteLine("Student finns redan.");
                return;
            }
        }
        Students.Add(student);

    }
    public void ListStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("Inga studenter.");
        }
        foreach (var item in Students)
        {
            Console.WriteLine(item);
        }
    }

     public void AddTeacher(Teacher teacher)
    {
        foreach(var item in Teachers)
        {
            if(item.PersonNumber == teacher.PersonNumber)
            {
                Console.WriteLine("Läraren finns redan.");
                return;
            }
        }
        Teachers.Add(teacher);

    }
    public void ListTeachers()
    {
        if (Teachers.Count == 0)
        {
            Console.WriteLine("Inga teacher.");
        }
        foreach (var item in Teachers)
        {
            Console.WriteLine(item);
        }
    }
}
