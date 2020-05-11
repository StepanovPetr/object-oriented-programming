using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibExample
{
    public interface IBinarySerialization
    {
        // Метод для бинарной серилизации.
        public bool BinarySerialization(string fileName = "Man.bin");

        // Метод для бинарной десерилизации.
        Man BinaryDeserialization(string fileName = "Man.bin");
    }
}