using System;
using System.Threading;

namespace _010_Thread
{
    internal class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread(object id)
        {
            try
            {
                Console.WriteLine($"{id}  started");
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{id} normal thread work");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"{id} finished");
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string) abortException.ExceptionState);
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            var thread = new Thread(MethodForThread);
            var thread2 = new Thread(MethodForThread);
            var thread3 = new Thread(MethodForThread);

            // Установка приорететов потоков.
            thread.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Lowest;
            thread3.Priority = ThreadPriority.Highest;

            thread.Start("001");
            thread2.Start("002");
            thread3.Start("003");

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
        }
    }
}