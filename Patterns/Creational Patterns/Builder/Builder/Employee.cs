// Класс экземпляр которого нужно построить.
namespace Builder 
{
    class Employee : IEmployee
    {
        public string FirstName { get; set;}

        public string LastName { get; set;}

        public string Department { get; set;}

        public string ManagerName { get; set;}

        public string Position { get; set;}

    }
}
