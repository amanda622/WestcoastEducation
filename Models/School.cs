using WestcoastEducation.Enums;

namespace WestcoastEducation.Models;

public class School
{
    //aggregation
    public List<Course> Courses { get; set; } = [];

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
    public void ListCourses()
    {
        foreach ( var item in Courses)
        {
            Console.WriteLine(item);
        }
    }

}
