// Пространство имен для работы с реестом.
using Microsoft.Win32;
using System;

namespace _022_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Установка покета Microsoft.Win32.Registry.

            Console.WriteLine(Registry.LocalMachine.Name);

            var currentVersionF = Registry.LocalMachine.OpenSubKey("Software")
                .OpenSubKey("Microsoft")
                .OpenSubKey("Windows NT")
                .OpenSubKey("CurrentVersion");

            var currentVersionS = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");

            Console.WriteLine(currentVersionF.ValueCount);

            var values = currentVersionF.GetValueNames();
            foreach (var value in values)
            { 
                Console.WriteLine($"{value}  -- {currentVersionF.GetValue(value)}" );
            }

            Console.WriteLine(currentVersionS);
            Console.ReadLine();
        }
    }
}
