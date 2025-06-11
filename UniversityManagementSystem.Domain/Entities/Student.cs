namespace UniversityManagementSystem.Domain.Entities
{
    public class Student
    {
        public Guid Guid { get; set; }

        public string StudentId { get; set; }
        public string StudentName { get; set; } 
        public string NominalClassId { get; set; }



        public StudentProfile StudentProfile { get; set; }
        public NominalClass NominalClass { get; set; }
    }
}
