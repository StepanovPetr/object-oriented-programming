using System;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Task
{
    internal class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread(object? o)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");
        }

        private static void MethodForThread(int param1, int param2, int param3)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");
        }

        static void Main(string[] args)
        {
            Task t = new Task(MethodForThread, 6);
            t.Start();

            new Task(MethodForThread, 6).Start();

            Task.Run(() =>  MethodForThread(123));

            Task.Run(() => MethodForThread(1, 2, 3));

            Console.ReadLine();
        }
    }
}
