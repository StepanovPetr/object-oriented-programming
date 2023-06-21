using Chain_of_Responsibility.Enums;

namespace Chain_of_Responsibility
{
    public class Student
    {
        public string Name { get; }

        public Faculty Faculty { get; }

        public Student(string name, Faculty faculty)
        {
            this.Faculty = faculty;
            this.Name = name;
        }
    }
}