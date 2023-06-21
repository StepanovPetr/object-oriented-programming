using System;
using System.Threading;

namespace _016_ThreadPool
{
    internal class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread(object id)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            Console.WriteLine($"{id}  started");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"{id} normal thread work");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"{id} finished");
        }

        static void Main(string[] args)
        {
            int countThread;
            int completionPortThreads;

            ThreadPool.GetAvailableThreads(out countThread, out completionPortThreads);
            Console.WriteLine($"The number of available worker threads - {countThread}, number of available asynchronous I/O threads {completionPortThreads}");

            ThreadPool.GetMaxThreads(out countThread, out completionPortThreads);
            Console.WriteLine($"The number of MAX worker threads - {countThread}, number of MAX asynchronous I/O threads {completionPortThreads}");

            ThreadPool.GetMinThreads(out countThread, out completionPortThreads);
            Console.WriteLine($"The number of MIN worker threads - {countThread}, number of MIN asynchronous I/O threads {completionPortThreads}");

            ThreadPool.UnsafeQueueUserWorkItem(MethodForThread, "001");
            ThreadPool.UnsafeQueueUserWorkItem(MethodForThread, "002");
            ThreadPool.UnsafeQueueUserWorkItem(MethodForThread, "003");

            ThreadPool.GetAvailableThreads(out countThread, out completionPortThreads);
            Console.WriteLine($"The number of available worker threads - {countThread}, number of available asynchronous I/O threads {completionPortThreads}");
            Console.ReadLine();
        }
    }
}
