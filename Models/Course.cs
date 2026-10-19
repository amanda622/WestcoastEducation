using WestcoastEducation.Enums;
namespace WestcoastEducation.Models;

public class Course
{
    public required string CourseNumber { get; set; } 
    public required string Title { get; set; }
    public required int LengthInWeeks { get; set; }
    
    public required DateTime StartDate {get; set;}
    public DateTime EndDate 
    {
        get {return StartDate.AddDays(LengthInWeeks * 7);}
    }

    public required CourseType CourseType {get; set;}

    public override string ToString()
    {
        return $"CourseNumber: {CourseNumber} | Title: {Title} | CourseType: {CourseType} | StartDate: {StartDate:yyyy-MM-dd}| EndDate: {EndDate:yyyy-MM-dd} | LengthInWeeks: {LengthInWeeks}" ;
    }
}
