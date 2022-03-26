using System;

// Пример построяния обьекта используя Builder.
namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employeeBuilder = new EmployeeBuilder();
            var employee = EmployeeBuilder.CreateBuilder()
                .SetFirstName("Вася")
                .SetLastName("Иванов")
                .SetDepartment("Отдел разработки")
                .SetPositon(".Net разработчик")
                .SetManagerName("Линус Торвальдс")
                .Build();

            Console.ReadLine();
        }
    }
}