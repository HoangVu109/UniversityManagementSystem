namespace UniversityManagementSystem.Domain.Entities;

public class Lecturer
{
    public Guid Guid { get; set; }

    public string LecturerId { get; set; }
    public string LecturerName { get; set; }
    
    
    public Guid MajorGuid { get; set; }
    public Major Major { get; set; }
}
