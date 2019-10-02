using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Вася", "Пупкин", 65);
            Man manFromFile = null;
            using (FileStream stream = new FileStream("Man.bin", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();           
                binaryFormatter.Serialize(stream, man);
            }
            Console.WriteLine(man.ManInfo());

            using (FileStream stream = new FileStream("Man.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                manFromFile =  binaryFormatter.Deserialize(stream) as Man;
            }
            Console.WriteLine(manFromFile.ManInfo());
            Console.ReadLine();
        }
    }
}
