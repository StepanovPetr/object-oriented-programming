using System;
using LibExample.DependencyInjection;

namespace _009_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.GetStudent("ivan.ivanov@example.com");

            Console.WriteLine("Hello World!");
        }
    }
}
