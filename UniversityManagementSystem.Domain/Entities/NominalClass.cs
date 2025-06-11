namespace UniversityManagementSystem.Domain.Entities
{
    public class NominalClass
    {
        public Guid Guid { get; set; }

        public string NominalClassId { get; set; }
        public string NominalClassName {  get; set; }


        public Guid FacultyGuid {  get; set; }
        public Major Major {  get; set; }

        public List<Student> Students { get; set; }
    }
}
