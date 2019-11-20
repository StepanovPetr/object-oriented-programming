using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // необходимое пространство имен для работы с файлама, папками, дисками и файловыми потокамиnamespace _02_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания файла.
            File.Create("Example.txt").Dispose();

            // Пример добавления текста в конец файла.
            File.AppendAllText("Example.txt", "Some text");
            
            // Пример копирования файла.
            File.Copy("Example.txt","Example2.txt");
            
            // Пример переименования, Перемещения файла.
            File.Move("Example2.txt", "Example3.txt");
            
            // Пример проверки существования файла.
            if (File.Exists("Example.txt"))
                //Пример удаления файла.
                File.Delete("Example.txt");
        }
    }
}
