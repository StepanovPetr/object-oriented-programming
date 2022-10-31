// Пространство имен для работы с реестом.
using Microsoft.Win32;

using System;
using System.IO;

namespace _023_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Установка покета Microsoft.Win32.Registry.

            Console.WriteLine(Registry.LocalMachine.Name);

            // c:\users\druid\downloads\telegram desktop\1.jpg
            var reg = Registry.CurrentUser.OpenSubKey("Control Panel",true)
                .OpenSubKey("Desktop", true);

            Console.WriteLine($"Wallpaper  - {reg.GetValue("Wallpaper")}");
            
            var picPath = Path.GetFullPath(@"pics/pic.jpg");
            Console.WriteLine(picPath);

            reg.SetValue("Wallpaper", picPath);
            reg.Close();

            reg = Registry.CurrentUser.OpenSubKey("Software", true)
                .OpenSubKey("Microsoft", true)
                .OpenSubKey("Windows", true)
                .OpenSubKey("CurrentVersion", true)
                .OpenSubKey("Policies", true);

            //reg.CreateSubKey("Wallpaper");
            //reg.SetValue("Wallpaper", picPath);

            Console.ReadLine();
        }
    }
}
