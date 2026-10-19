using WestcoastEducation.Enums;
using WestcoastEducation.Models;

namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        Course course = new()
        {
            CourseNumber = "123",
            Title = "Fysik",
            StartDate = new DateTime(2026,11,2),
            LengthInWeeks = 10,
            CourseType = CourseType.Klassrum
        };
        Console.WriteLine(course);
     }
}
