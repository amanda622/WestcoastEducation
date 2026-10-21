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
            StartDate = new DateTime(2026, 11, 2),
            LengthInWeeks = 10,
            CourseType = CourseType.Klassrum
        };
        Console.WriteLine(course);

        Teacher teacher = new()
        {
            PersonNumber = "19771110-7798",
            FirstName = "Amanda",
            LastName = "Karlson",
            Email = "amanda.karlson@gmail.com",
            Phone = "0705983391",
            Address = new()
            {
                AddressLine = "StorGatan 12",
                PostalCode = "421 45",
                City = "Stockholm"
            },
            KnowledgeArea = "Fysik",

        };
        teacher.Courses.Add(course);
        Console.WriteLine(teacher);

        EducationLeader educationLeader = new()
        {
            PersonNumber = "19771110-7798",
            FirstName = "Torb",
            LastName = "Gunner",
            Email = "torb.gunner@gmail.com",
            Phone = "0709853313",
            Address = new()
            {
                AddressLine = "StorGatan 28",
                PostalCode = "421 38",
                City = "Goteborg"
            },
            KnowledgeArea = "Fysik",

            EmploymentDate = new DateTime(2014, 12, 30),
        };
        Console.WriteLine(educationLeader);

        School school = new();

        school.ListCourses();

        school.AddCourse(course);
        school.ListCourses();

        Course sameNumber = new()
        {
            CourseNumber = "123",
            Title = "Kemi",
            StartDate = new DateTime(2027, 1, 11),
            LengthInWeeks = 8,
            CourseType = CourseType.Distans
        };
        school.AddCourse(sameNumber);
        school.ListCourses();

        Course newNumber = new()
        {
            CourseNumber = "456",
            Title = "Kemi",
            StartDate = new DateTime(2027, 1, 11),
            LengthInWeeks = 8,
            CourseType = CourseType.Distans
        };
        school.AddCourse(newNumber);
        school.ListCourses();

        school.ListStudent();
        school.AddStudent(student);
        school.ListStudent();
        Student studentSamePersonNum = new()
        {
            PersonNumber = "19871210-8898",
            FirstName = "Torb",
            LastName = "Gunner",
            Email = "torb.gunner@gmail.com",
            Phone = "0709853313",
            Address = new()
            {
                AddressLine = "StorGatan 28",
                PostalCode = "421 38",
                City = "Goteborg"
            },
        };
        school.AddStudent(studentSamePersonNum);
        school.ListStudent();

        Student newStudent = new()
        {
            PersonNumber = "19991210-1198",
            FirstName = "Torb",
            LastName = "Gunner",
            Email = "torb.gunner@gmail.com",
            Phone = "0709853313",
            Address = new()
            {
                AddressLine = "StorGatan 28",
                PostalCode = "421 38",
                City = "Goteborg"
            },
        };
        school.AddStudent(newStudent);
        school.ListStudent();

    }
}
