using System;

namespace _018_boxing
{
    // boxing (Упаковка) - копирование valueType из стека потока в Управляемую кучу.
    internal class Program
    {
        static void Main(string[] args)
        {
            int valType = 10;
            object refType = valType;
            valType = 11;

            Console.WriteLine(valType);
            Console.WriteLine(refType);
            Console.ReadLine();

            Console.WriteLine(valType.GetHashCode());
            Console.WriteLine(refType.GetHashCode());
            Console.ReadLine();
        }
    }
}
