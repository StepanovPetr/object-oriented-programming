using System;
using LibExample;

namespace _003_Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentFirst = StudentFactory.CreateStudent("Вася", "Васильев", 1, "фитикс");
            var studentSecond = StudentFactory.CreateStudent("Иван", "Иванов", 2, "фтнг");


            Console.WriteLine(studentFirst.GetHashCode());
            Console.WriteLine(studentSecond.GetHashCode());
            Console.ReadLine();
        }
    }
}
