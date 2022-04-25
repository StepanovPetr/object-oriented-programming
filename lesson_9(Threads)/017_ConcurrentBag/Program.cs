using System;
// Пространство имен для работы с конкурентными коллекциями.
using System.Collections.Concurrent;
using System.Threading;

namespace _017_ConcurrentBag
{
    internal class Program
    {
        // Пример потокобезопасной коллекции.
        static ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>();

        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread(object id)
        {
            Console.WriteLine($"{id}  started");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"{id} normal thread work");
                Thread.Sleep(1000);
                concurrentBag.Add($"{id} - {i}");
            }

            Console.WriteLine($"{id} finished");
        }

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(MethodForThread, "001");
            ThreadPool.QueueUserWorkItem(MethodForThread, "002");
            ThreadPool.QueueUserWorkItem(MethodForThread, "003");
            ThreadPool.QueueUserWorkItem(MethodForThread, "004");

            Thread.Sleep(11000);
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
