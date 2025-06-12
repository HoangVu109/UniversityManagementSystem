using UniversityManagementSystem.Domain.Enums;

namespace UniversityManagementSystem.Domain.ValueObjects;

public class ClassPeriod
{
    public Period StartPeriod { get; }
    public Period EndPeriod { get; }

    public ClassPeriod(Period startPeriod, Period endPeriod)
    {
        if ((int)startPeriod > (int)endPeriod)
        {
            throw new ArgumentException("Start period must be less than or equal to end period.");
        }
        StartPeriod = startPeriod;
        EndPeriod = endPeriod;
    }

    // Tính số lượng tiết học trong khoảng
    public int GetPeriodCount()
    {
        return (int)EndPeriod - (int)StartPeriod + 1;
    }

    // Kiểm tra xem một tiết có nằm trong khoảng không
    public bool Contains(Period period)
    {
        return (int)period >= (int)StartPeriod && (int)period <= (int)EndPeriod;
    }

}
