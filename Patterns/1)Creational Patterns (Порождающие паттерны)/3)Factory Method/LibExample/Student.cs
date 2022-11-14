using System.Collections.Generic;

namespace LibExample
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string ManagerName { get; set; }

        public int YearOfStudy { get; set; }

        public IEnumerable<string> Subjects { get; set; }
    }
}
