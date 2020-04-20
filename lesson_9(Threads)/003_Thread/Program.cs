using System;
using System.Threading;

namespace _003_Thread
{
    class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThread()
        {
            while (true)
            {
                Console.WriteLine($"Second Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }

        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThreadWithParameter(object obj)
        {
            while (true)
            {
                Console.WriteLine($"Third Thread {Thread.CurrentThread.ManagedThreadId} Parameter - {obj}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // Пример предположения типа делегата.
            Thread thread = new Thread(MethodForThread);
            // Запуск потока.
            thread.Start();

            // Пример предположения типа делегата.
            Thread threadWihtParametr = new Thread(MethodForThreadWithParameter);
            // Запуск потока.
            threadWihtParametr.Start(123456);

            while (true)
            {
                Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }
}
