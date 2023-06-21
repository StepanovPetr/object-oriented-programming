namespace LibExample
{
    public interface IBinarySerialization
    {
        // Метод для бинарной серилизации.
        bool BinarySerialization(string fileName = "Man.bin");

        // Метод для бинарной десерилизации.
        Man BinaryDeserialization(string fileName = "Man.bin");
    }
}