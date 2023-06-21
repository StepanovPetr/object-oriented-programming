using System;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Task
{
    internal class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");
        }

        static void Main(string[] args)
        {
            //ThreadPool.QueueUserWorkItem(MethodForThread);
             Task t = new Task(MethodForThread);
            t.Start();

            new Task(MethodForThread).Start();

            Task.Run(MethodForThread);

            Console.ReadLine();
        }
    }
}
