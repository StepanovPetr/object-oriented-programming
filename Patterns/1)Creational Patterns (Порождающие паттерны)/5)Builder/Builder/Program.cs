using System;

using LibExample.Builders;
using LibExample.Enums;

// Пример построяния обьекта используя Builder.
namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employee = EmployeeBuilderSecond.CreateBuilder()
                .SetFirstName("Вася")
                .SetLastName("Иванов")
                .SetDepartment(Department.It)
                .SetPosition(Position.Senior)
                .SetManagerName("Линус Торвальдс")
                .Build();

            Console.ReadLine();
        }
    }
}