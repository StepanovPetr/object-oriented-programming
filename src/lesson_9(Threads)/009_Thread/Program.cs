using System;
using System.Threading;

namespace _009_Thread
{
    class Program
    {
        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThread(object id)
        {
            try
            {
                // Установка потока как фонового.(Если завершится основной поток завершаться и все дочерние)
                Thread.CurrentThread.IsBackground = true;
                Console.WriteLine($"{id}  started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{id} normal thread work");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"{id} finished");
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            Thread thread = new Thread(MethodForThread);
            Thread thread2 = new Thread(MethodForThread);
            Thread thread3 = new Thread(MethodForThread);

            thread.Start("001");
            thread2.Start("002");
            thread3.Start("003");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Main thread work");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
        }
    }
}
