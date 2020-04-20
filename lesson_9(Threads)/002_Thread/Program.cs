using System;
using System.Threading;

namespace _002_Thread
{
    class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThreadWithParameter(object obj)
        {
            while (true)
            {
                Console.WriteLine($"Second Thread {Thread.CurrentThread.ManagedThreadId} Parameter - {obj}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // Делагат для работы потока с параметром.
            ParameterizedThreadStart delegateForThreadStart = new ParameterizedThreadStart(MethodForThreadWithParameter);
            // Создание потока связанного с методом.
            Thread thread = new Thread(delegateForThreadStart);
            // Запуск потока.
            thread.Start(123 );

            while (true)
            {
                Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }
}
