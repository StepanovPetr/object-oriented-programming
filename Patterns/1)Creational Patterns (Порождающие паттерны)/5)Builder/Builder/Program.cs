using System;

using LibExample.Builders;
using LibExample;
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
                .SetDepartment("Отдел разработки")
                .SetPosition(".Net разработчик")
                .SetManagerName("Линус Торвальдс")
                .Build();

            Console.ReadLine();
        }
    }
}