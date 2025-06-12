namespace UniversityManagementSystem.Domain.Entities;

public class Faculty
{
    public Guid Guid { get; set; }

    public string FacultyId { get; set; }
    public string FacultyName { get; set; }

    public List<Major> Majors { get; set; }
    public List<Course> Courses { get; set; }
}
