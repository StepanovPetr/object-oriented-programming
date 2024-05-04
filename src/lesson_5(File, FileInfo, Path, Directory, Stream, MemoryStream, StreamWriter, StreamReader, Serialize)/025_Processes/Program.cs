using System;
using System.Diagnostics;

namespace _025_Processes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var process = Process.Start("arp", "-a");
            process = Process.Start("ipconfig", "-all");

            process = Process.Start("calc", "www.google.ru");
            ///process = Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "www.google.ru");

            Console.ReadLine();
        }
    }
}
