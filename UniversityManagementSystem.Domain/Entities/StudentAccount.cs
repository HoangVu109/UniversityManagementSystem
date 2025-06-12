namespace UniversityManagementSystem.Domain.Entities;

public class StudentAccount
{
    public string StudentId { get; set; }
    public string Password { get; set; }

    public Guid StudentGuid { get; set; }

    public Student Student { get; set; }
}
