namespace LibExample.DependencyInjection;

/// <summary> Деканат. </summary>
public class Deanery
{
    private readonly IDepartment _department;

    public Deanery(IDepartment department)
    {
        _department = department;
    }

    public Student SetStudentnetAssessment(string email)
    {
        var student = _department.GetStudent(email);

        if (student.ObjectOrientedProgramming >= 90)
        {
            student.Scholarship += 100000;
        }

        if (student.OperatingSystems >= 90)
        {
            student.Scholarship += 100000;
        }

        return student;
    }
}