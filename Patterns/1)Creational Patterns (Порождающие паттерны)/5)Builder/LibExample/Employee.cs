// Класс экземпляр которого нужно построить.

using LibExample.Enums;

namespace LibExample 
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set;}

        public string LastName { get; set;}

        public Department Department { get; set;}

        public string ManagerName { get; set;}

        public Position Position { get; set;}

    }
}
