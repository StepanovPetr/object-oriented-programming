using System;
using System.IO;

namespace _017_Stream
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Чтение, Запись побайтово.
            using (Stream stream = new MemoryStream())
            {
                Console.WriteLine("Чтение, Запись побайтово.");
                // Записываем байты в файл.
                for (var i = 0; i < 256; i++) stream.WriteByte((byte) i);

                Console.WriteLine(stream.Position);
                // Переставляем внутренний указатель на начало.
                stream.Position = 0;

                // Считывам байты из файла.
                for (var i = 0; i < 256; i++) Console.Write(" " + stream.ReadByte());
                Console.WriteLine();
            }

            // Чтение, Запись массива байт.
            using (Stream stream = new MemoryStream())
            {
                Console.WriteLine("Чтение, Запись массива байт.");
                var massofByte = new byte[256];
                var massFromFile = new byte[256];

                for (var i = 0; i < 256; i++) massofByte[i] = (byte) i;

                // Записываем байты в файл.
                stream.Write(massofByte, 0, massofByte.Length);
                // Переставляем внутренний указатель на начало.
                stream.Position = 0;
                stream.Read(massFromFile, 0, massFromFile.Length);

                for (var i = 0; i < 256; i++) Console.Write(" " + massFromFile[i]);
            }
            Console.ReadKey();
        }
    }
}