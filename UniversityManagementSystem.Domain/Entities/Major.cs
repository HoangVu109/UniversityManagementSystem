namespace UniversityManagementSystem.Domain.Entities
{
    public class Major
    {
        public Guid Guid { get; set; }

        public string MajorId { get; set; }
        public string MajorName { get; set; }

        public Guid FacultyGuid { get; set; }
        public Faculty Faculty { get; set; }

        public List<NominalClass> NominalClasses { get; set; }
    }
}
