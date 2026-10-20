namespace WestcoastEducation.Models;

public class Teacher:Person
{
    public string KnowledgeArea {get; set;} = "";
    // Aggregation
    public List<Course> Courses { get; set; } = [];
    public override string ToString()
    {
        return $"{base.ToString()} KnowledgeArea: {KnowledgeArea} Courses: {Courses.Count}" ;
    }
}
