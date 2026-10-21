namespace WestcoastEducation.Models;

public class School
{
    //aggregation
    public List<Course> Courses { get; set; } = [];
    public List<Student> Students { get; set; } = [];

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
    public void ListStudent()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine(" Inga studenter.");
        }
        foreach (var item in Students)
        {
            Console.WriteLine(item);
        }
    }
}
