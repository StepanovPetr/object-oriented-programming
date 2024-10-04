using LibExample.DependencyInjection;

namespace UnitTests;

public class DepartmentMock : IDepartment
{
    public Student GetStudent(string email)
    {
        return new Student()
        {
            ObjectOrientedProgramming = 90
        };
    }
}