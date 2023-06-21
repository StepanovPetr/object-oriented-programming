using System;
using System.Threading;

namespace _014_Thread_Semaphore_
{
    internal class Program
    {
        // Переменная нового семафора.
        private static readonly Semaphore mySemaphore = new Semaphore(2, 2, "MySemaphore");

        // Метод который будет выполняться в отдельном потоке.
        private static void MethodForThread(object id)
        {
            Console.WriteLine($"{id}  started");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"{id} normal thread work");
                Thread.Sleep(1000);
            }

            // Пример критической секции которая может выоплятся только одним потоком
            mySemaphore.WaitOne();

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"{id} Critical Section");
                Thread.Sleep(2000);
            }

            Console.WriteLine($"{id} finished");

            // Освобождение семафора.
            mySemaphore.Release();
        }

        private static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            var thread = new Thread(MethodForThread);
            var thread2 = new Thread(MethodForThread);
            var thread3 = new Thread(MethodForThread);

            thread.Start("001");
            thread2.Start("002");
            thread3.Start("003");

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
            Console.ReadLine();
        }
    }
}
