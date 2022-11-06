using System;

// Пространство имен для работы с процессами.
using System.Diagnostics;

namespace _024_Processes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processes =  Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine(
                        $"{process.Id}  -- {process.ProcessName}  {process.BasePriority} ");
            }

            foreach (var process in processes)
            {
                if (process.ProcessName == "chrome")
                {
                    process.Kill();
                }
            }

            //foreach (var process in processes)
            //{
            //    if (process.ProcessName.ToLower().Contains("avast"))
            //    {
            //        process.Kill();
            //    }
            //}
            Console.ReadLine();
        }
    }
}
