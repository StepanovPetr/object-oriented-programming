using System;
using System.Threading;

#region Links
// https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=netcore-3.0
#endregion
namespace _001_Thread
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

        static void Main(string[] args)
        {
            // Делагат для работы потока без параметров.
            ThreadStart delegateForThreadStart = new ThreadStart(MethodForThread);
            // Создание потока связанного с методом.
            Thread thread = new Thread(delegateForThreadStart);
            // Запуск потока.
            thread.Start();

            while (true)
            {
                Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }
}
