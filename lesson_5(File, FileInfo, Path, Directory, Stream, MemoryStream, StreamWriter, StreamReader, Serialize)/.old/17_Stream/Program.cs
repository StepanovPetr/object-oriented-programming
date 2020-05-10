using System;
using System.IO;

//  https://docs.microsoft.com/en-us/dotnet/api/system.io.stream.beginread?view=netframework-4.5
//  https://www.tutorialsteacher.com/csharp/csharp-stream-io
namespace _17_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чтение, Запись побайтово.
            using (Stream stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Console.WriteLine("Чтение, Запись побайтово.");
                // Записываем байты в файл.
                for (int i = 0; i < 256; i++)
                {
                    stream.WriteByte((byte)i);
                }

                Console.WriteLine(stream.Position);
                // Переставляем внутренний указатель на начало.
                stream.Position = 0;

                // Считывам байты из файла.
                for (int i = 0; i < 256; i++)
                {
                    Console.Write(" " + stream.ReadByte());
                }
                Console.WriteLine();
                //stream.Close();
            }

            // Чтение, Запись массива байт.
            using (Stream stream = new FileStream("Test.dat", FileMode.Create, FileAccess.ReadWrite))
            {
                Console.WriteLine("Чтение, Запись массива байт.");
                byte[] massofByte = new byte[256];
                byte[] massFromFile = new byte[256];
              
                for (int i = 0; i < 256; i++)
                {
                    massofByte[i]=((byte)i);
                }

                // Записываем байты в файл.
                stream.Write(massofByte, 0, massofByte.Length);
                // Переставляем внутренний указатель на начало.
                stream.Position = 0;


                stream.Read(massFromFile, 0, massFromFile.Length);

                for (int i = 0; i < 256; i++)
                {
                    Console.Write(" " + massFromFile[i]);
                }

            } 
            Console.ReadKey();
        }
    }
}
