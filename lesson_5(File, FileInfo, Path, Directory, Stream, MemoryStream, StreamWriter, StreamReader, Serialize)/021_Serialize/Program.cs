using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using LibExample;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace _021_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Install-Package Newtonsoft.Json  -Version 12.0.2
            Man man = new Man("Вася", "Пупкин", 65);
            Man manFromFile = null;
            using (StreamWriter stream = File.CreateText("Man.json"))
            {
                // Пример JSON серилизации.
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, man);
            }
            Console.WriteLine(man.ManInfo());

            using (StreamReader file = File.OpenText("Man.json"))
            {
                // Пример JSON десерилизации.
                JsonSerializer serializer = new JsonSerializer();
                manFromFile = (Man)serializer.Deserialize(file, typeof(Man));
            }
            Console.WriteLine(manFromFile.ManInfo());
            Console.ReadLine();
        }
    }
}
