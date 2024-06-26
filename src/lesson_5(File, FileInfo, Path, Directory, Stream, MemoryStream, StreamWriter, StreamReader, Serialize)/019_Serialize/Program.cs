﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LibExample;

namespace _019_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Иванов", "Иван", 65);
            Man manFromFile = null;
            using (FileStream stream = new FileStream("Man.bin", FileMode.Create))
            {
                // Пример двоичной сериализации.
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, man);
            }
            Console.WriteLine(man.ManInfo());

            using (FileStream stream = new FileStream("Man.bin", FileMode.Open))
            {
                // Пример двоичной десеарилизации.
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                manFromFile = (Man)binaryFormatter.Deserialize(stream);
            }
            Console.WriteLine(manFromFile.ManInfo());
            Console.ReadLine();
        }
    }
}
