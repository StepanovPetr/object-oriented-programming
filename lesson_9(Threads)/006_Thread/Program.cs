using System;
using System.Threading;

namespace _006_Thread
{
    class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThread()
        {
            Console.WriteLine($"Second Thread {Thread.CurrentThread.ManagedThreadId} started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Second Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Second Thread {Thread.CurrentThread.ManagedThreadId} finished");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            Thread thread = new Thread(MethodForThread);
            // Запуск потока.
            thread.Start();
            Thread.Sleep(3000);
            // Ожидание завершения дочернего потока по таймауту(Закоментировать для примера).
            thread.Join(1);
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
            Console.ReadLine();
        }
    }
}
