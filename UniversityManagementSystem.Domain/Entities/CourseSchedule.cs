using UniversityManagementSystem.Domain.ValueObjects;

namespace UniversityManagementSystem.Domain.Entities;

internal class CourseSchedule
{
    public Guid Guid { get; set; }
    public ClassPeriod ClassPeriod { get; set; }
    


    public Guid CourseGuid { get; set; }
    public Course Course { get; set; }
}
