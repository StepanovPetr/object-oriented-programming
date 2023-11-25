using System;
using LibExample;

namespace _013_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new WindowsCmdManager();

            var result =  manager.GetArpTable();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            result = manager.GetTracertTable("ya.ru");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
