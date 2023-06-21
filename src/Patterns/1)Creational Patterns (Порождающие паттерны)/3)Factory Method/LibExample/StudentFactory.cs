using System.Collections.Generic;

namespace LibExample
{
    public static class StudentFactory
    {
        private static Dictionary<string, string> managers = new Dictionary<string, string>()
        {
            { "фитикс", "декан фитикс" },
            { "фтнг", "декан фтнг" },
        };

        public static Student CreateStudent(string firstName, string lastName, int yearOfStudy,
            string department)
        {
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                YearOfStudy = yearOfStudy,
                Department = department,
                ManagerName = managers[department],
                Subjects = GetSubjects(yearOfStudy)
            };
        }

        private static IEnumerable<string> GetSubjects(int yearOfStudy)
        {
            switch(yearOfStudy)
            {
                case 1:
                    return new[] { "Программирование", "Физкультура" };
                case 2: return new[] { "ООП", "Опереционные системы", "Философия" };
                default: return new[] { "Физкультура", "Философия" };
            }
        }
    }
}