using System;
using System.Threading;

namespace _013_Thread_Mutex_
{
    internal class Program
    {
        // Переменная нового мьютекса.
        private static readonly Mutex myMutex = new Mutex(false, "MyMutex");

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
            myMutex.WaitOne();

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"{id} Critical Section");
                Thread.Sleep(2000);
            }

            Console.WriteLine($"{id} finished");

            // Освобождение мьютекса.
            myMutex.ReleaseMutex();
        }

        private static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            var thread = new Thread(MethodForThread);

            thread.Start("001");

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
            Console.ReadLine();
        }
    }
}