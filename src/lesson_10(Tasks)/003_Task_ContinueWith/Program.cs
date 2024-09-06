using System;
using System.Threading;
using System.Threading.Tasks;

namespace _003_Task_ContinueWith
{
    internal class Program
    {
        private static bool MethodForThread(object? o)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");

            return true;
        }

        private static bool MethodForThread2(object? o)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");

            return true;
        }

        static void Main(string[] args)
        {
            Task<bool> t = new Task<bool>(MethodForThread, 6);
            t.Start();

            t.ContinueWith(x =>  MethodForThread2(6));
            Console.ReadLine();
        }
    }
}
