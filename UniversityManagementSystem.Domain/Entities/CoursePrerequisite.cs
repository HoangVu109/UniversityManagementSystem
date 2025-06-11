namespace UniversityManagementSystem.Domain.Entities
{
    public class CoursePrerequisite
    {
        public Guid CourseGuid { get; set; }
        public Course Course { get; set; }

        public Guid PrerequisiteGuid { get; set; }
        public Course Prerequisite { get; set; }
    }
}   