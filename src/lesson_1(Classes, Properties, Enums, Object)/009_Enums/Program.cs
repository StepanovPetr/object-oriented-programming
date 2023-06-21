using System;
using _009_Enums.Enums;

namespace _009_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTask task = new MyTask(WeekDays.Wednesday, "Помыть посуду");
            MyTask task2 = new MyTask(WeekDays.Friday, "Захватить мир");

            Console.WriteLine(task.Message);
            Console.WriteLine(task2.Message);
            Console.ReadLine();
        }
    }
}
