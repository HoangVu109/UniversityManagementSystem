namespace UniversityManagementSystem.Domain.Entities;

public class Course
{
    public Guid Guid { get; set; }

    public int CourseId { get; set; }
    public string CourseName { get; set; }


    public List<CoursePrerequisite> Prerequisites { get; set; } 
    public List<CoursePrerequisite> RequiredByCourses { get; set; }

    //Khoa chủ quản
    public Guid FacultyGuid { get; set; }
    public Faculty Faculty { get; set; }


}
