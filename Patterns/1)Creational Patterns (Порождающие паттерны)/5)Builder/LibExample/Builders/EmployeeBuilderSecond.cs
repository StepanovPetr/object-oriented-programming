namespace LibExample.Builders
{
    /// <summary> Пример билдера создающего экземпляр класса Employee. </summary>
    public class EmployeeBuilderSecond : IEmployeeBuilder
    {
        private Employee _employee = new Employee();

        /// <summary> Создание нового экземпляра EmployeeBuilderSecond. </summary>
        /// <returns> Новый экземпляр EmployeeBuilderSecond </returns>
        public static IEmployeeBuilder CreateBuilder() => new EmployeeBuilderSecond();

        /// <summary> Создание нового экземпляра EmployeeBuilderSecond с корректными параметрами. </summary>
        /// <returns> Новый экземпляр EmployeeBuilderSecond </returns>
        public static IEmployeeBuilder CreateCorrectBuilder() => new EmployeeBuilderSecond()
                .SetFirstName("Вася")
                .SetLastName("Иванов")
                .SetDepartment("Отдел разработки")
                .SetPosition(".Net разработчик")
                .SetManagerName("Линус Торвальдс");

        public IEmployeeBuilder SetFirstName(string firstName)
        {
            _employee.FirstName = firstName;
            return this;
        }

        public IEmployeeBuilder SetLastName(string lastName)
        {
            _employee.LastName = lastName;
            return this;
        }

        public IEmployeeBuilder SetDepartment(string department)
        {
            _employee.Department = department;
            return this;
        }

        public IEmployeeBuilder SetManagerName(string managerName)
        {
            _employee.ManagerName = managerName;
            return this;
        }

        public IEmployeeBuilder SetPosition(string position)
        {
            _employee.Position = position;
            return this;
        }

        /// <summary> Получение экземпляра класса Employee. </summary>
        /// <returns> Экземпляр класса Employee. </returns>
        public IEmployee Build() => _employee;
    }
}
