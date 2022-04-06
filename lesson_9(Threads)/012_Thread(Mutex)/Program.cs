using System;
using System.Threading;

namespace _012_Thread_Mutex_
{
    internal class Program
    {
        // Переменная нового мьютекса.
        private static Mutex myMutex = new Mutex();

        // Метод который будет выполняться в отдельном потоке.
        static void MethodForThread(object id)
        {
            try
            {
                Console.WriteLine($"{id}  started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{id} normal thread work");
                    Thread.Sleep(1000);
                }

                // Пример критической секции которая может выоплятся только одним потоком
                myMutex.WaitOne();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{id} Critical Section");
                    Thread.Sleep(2000);
                }

                Console.WriteLine($"{id} finished");
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            finally
            {
                // Освобождение мьютекса.
                myMutex.ReleaseMutex();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} started");
            // Пример предположения типа делегата.
            Thread thread = new Thread(MethodForThread);
            Thread thread2 = new Thread(MethodForThread);

            thread.Start("001");
            thread2.Start("002");

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} finished");
            Console.ReadLine();
        }
    }
}