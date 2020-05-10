using System;
using System.IO;

namespace _011_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(Path.GetRandomFileName());

            Console.WriteLine("Получение дирректории для хранения временных файлов");
            Console.WriteLine(Path.GetTempPath());

            Console.WriteLine("Создание временного файла и возвращение его имени");
            Console.WriteLine(Path.GetTempFileName());

            Console.ReadLine();
        }
    }
}
