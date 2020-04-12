// Пример билдера создающего экземпляр класса Employee.
namespace Builder
{
    class EmployeeBuilder : IEmployeeBuilder
    {
        private readonly Employee employee = new Employee();

        public EmployeeBuilder SetFirstName(string firstName)
        {
            employee.FirstName = firstName;
            return this;
        }

        public EmployeeBuilder SetLastName(string lastName)
        {
            employee.LastName = lastName;
            return this;
        }

        public EmployeeBuilder SetDepartment(string department)
        {
            employee.Department = department;
            return this;
        }

        public EmployeeBuilder SetManagerName(string managerName)
        {
            employee.ManagerName = managerName;
            return this;
        }

        public EmployeeBuilder SetPositon(string position)
        {
            employee.Position = position;
            return this;
        }

        public IEmployee Build() => employee;
    }
}
