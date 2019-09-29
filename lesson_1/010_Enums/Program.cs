using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task  = new Task( DayOfWeek.Wednesday , "Помыть посуду");
            Task task2 = new Task( DayOfWeek.Saturday, "Захватить мир");

            Console.WriteLine(task.Message);
            Console.WriteLine(task2.Message);

            Console.ReadLine();
        }
    }
}
