// Пример билдера создающего экземпляр класса Employee.
namespace Builder
{
    class EmployeeBuilder : IEmployeeBuilder
    {
        private Employee _employee = new Employee();

        public static EmployeeBuilder CreateBuilder() => new EmployeeBuilder();

        public static EmployeeBuilder CreateCorrectBuilder() => new EmployeeBuilder()
                .SetFirstName("Вася")
                .SetLastName("Иванов")
                .SetDepartment("Отдел разработки")
                .SetPositon(".Net разработчик")
                .SetManagerName("Линус Торвальдс");

        public EmployeeBuilder SetFirstName(string firstName)
        {
            _employee.FirstName = firstName;
            return this;
        }

        public EmployeeBuilder SetLastName(string lastName)
        {
            _employee.LastName = lastName;
            return this;
        }

        public EmployeeBuilder SetDepartment(string department)
        {
            _employee.Department = department;
            return this;
        }

        public EmployeeBuilder SetManagerName(string managerName)
        {
            _employee.ManagerName = managerName;
            return this;
        }

        public EmployeeBuilder SetPositon(string position)
        {
            _employee.Position = position;
            return this;
        }

        public IEmployee Build() => _employee;
    }
}
