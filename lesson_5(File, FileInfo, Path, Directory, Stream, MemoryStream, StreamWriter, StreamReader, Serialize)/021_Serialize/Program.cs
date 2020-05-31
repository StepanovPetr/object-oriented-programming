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
            //Install-Package Newtonsoft.Json  -Version 12.0.2
            var man = new Man("Вася", "Пупкин", 65);
            Man manFromFile = null;
            using (var stream = File.CreateText("Man.json"))
            {
                // Пример JSON серилизации.
                var serializer = new JsonSerializer();
                serializer.Serialize(stream, man);
            }

            Console.WriteLine(man.ManInfo());

            using (var file = File.OpenText("Man.json"))
            {
                // Пример JSON десерилизации.
                var serializer = new JsonSerializer();
                manFromFile = (Man) serializer.Deserialize(file, typeof(Man));
            }

            Console.WriteLine(manFromFile.ManInfo());
            Console.ReadLine();
        }
    }
}