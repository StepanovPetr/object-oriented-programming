using LibExample.Enums;

namespace LibExample.Builders
{
    public interface IEmployeeBuilder
    {
        /// <summary> Создание экземпляра класса IEmployee. </summary>
        /// <returns> Экземпляр класса IEmployee. </returns>
        IEmployee Build();

        /// <summary> Задать имя. </summary>
        /// <returns> Экземпляр класса IEmployeeBuilder. </returns>
        IEmployeeBuilder SetFirstName(string firstName);

        /// <summary> Задать фамилию. </summary>
        /// <returns> Экземпляр класса IEmployeeBuilder. </returns>
        IEmployeeBuilder SetLastName(string lastName);

        /// <summary> Задать отдел. </summary>
        /// <returns> Экземпляр класса IEmployeeBuilder. </returns>
        IEmployeeBuilder SetDepartment(Department department);

        /// <summary> Задать руководителя. </summary>
        /// <returns> Экземпляр класса IEmployeeBuilder. </returns>
        IEmployeeBuilder SetManagerName(string managerName);

        /// <summary> Задать должность. </summary>
        /// <returns> Экземпляр класса IEmployeeBuilder. </returns>
        IEmployeeBuilder SetPosition(Position position);
    }
}
