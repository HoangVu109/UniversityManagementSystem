namespace UniversityManagementSystem.Domain.Entities
{
    public class StudentProfile
    {
        // guid of Student
        public Guid StudentGuid { get; set; }

        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set; }
        public string StudentPicturePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string YearOfAcademic { get; set; }
    }
}
