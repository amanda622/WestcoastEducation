using WestcoastEducation.Enums;
using WestcoastEducation.Models;

namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        Student student = new()
        {
            PersonNumber = "19871210-8898",            
            FirstName = "Erik",
            LastName = "Eriksson",
            Email = "erik.eriksson@gmail.com",
            Phone = "0703982261",
            Address = new()
            {
                AddressLine = "StorGatan 1",
                PostalCode = "123 45",
                City = "Staden"
            }
        };
        Console.WriteLine(student);
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
