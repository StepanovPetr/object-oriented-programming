using LibExample.Enums;

namespace LibExample.Builders
{
    /// <summary> Пример билдера создающего экземпляр класса Employee. </summary>
    public class EmployeeBuilderFirst : IEmployeeBuilder
    {
        private string _firstName { get; set; } ="";
        private string _lastName { get; set; } = "";
        private Department _department { get; set; } = Department.Other;
        private string _managerName { get; set; } = "";
        private Position _position { get; set; } = Position.Junior;

        /// <summary> Создание нового экземпляра EmployeeBuilderSecond. </summary>
        /// <returns> Новый экземпляр EmployeeBuilderSecond </returns>
        public static IEmployeeBuilder CreateBuilder() => new EmployeeBuilderFirst();

        /// <summary> Создание нового экземпляра EmployeeBuilderSecond с корректными параметрами. </summary>
        /// <returns> Новый экземпляр EmployeeBuilderSecond </returns>
        public static IEmployeeBuilder CreateCorrectBuilder() => new EmployeeBuilderFirst()
        {
            _firstName = "Вася",
            _lastName = "Иванов",
            _department = Department.It,
            _managerName = ".Net разработчик",
            _position = Position.Senior
        };
           
        public IEmployeeBuilder SetFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public IEmployeeBuilder SetLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public IEmployeeBuilder SetDepartment(Department department)
        {
            _department = department;
            return this;
        }

        public IEmployeeBuilder SetManagerName(string managerName)
        {
            _managerName = managerName;
            return this;
        }

        public IEmployeeBuilder SetPosition(Position position)
        {
            _position = position;
            return this;
        }

        public IEmployee Build() => new Employee()
        {
            FirstName = _firstName,
            LastName = _lastName,
            Department = _department,
            ManagerName = _managerName,
            Position = _position
        };
    }
}
