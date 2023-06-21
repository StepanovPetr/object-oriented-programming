using System;
using System.IO;
using LibExample;
using Newtonsoft.Json;

namespace _021_Serialize
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Install-Package Newtonsoft.Json
            var man = new Man("Иван", "Иванов", 65);
            Man manFromFile = null;
            using (var stream = File.CreateText("Man.json"))
            {
                // Пример JSON сериализации.
                var serializer = new JsonSerializer();
                serializer.Serialize(stream, man);
            }

            Console.WriteLine(man.ManInfo());

            using (var file = File.OpenText("Man.json"))
            {
                // Пример JSON десериализации.
                var serializer = new JsonSerializer();
                manFromFile = (Man)serializer.Deserialize(file, typeof(Man));
            }

            Console.WriteLine(manFromFile.ManInfo());
            Console.ReadLine();
        }
    }
}