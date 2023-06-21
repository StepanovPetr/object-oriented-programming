using System;

namespace _019_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valType = 10;
            object refType = valType;
            valType = 11;
            int valType2 = (int)refType;

            //InvalidCastException  (Типы должны точно совпадать) .
            //int valType2 = (short)refType;

            refType = 12;

            Console.WriteLine(valType);
            Console.WriteLine(refType);
            Console.WriteLine(valType2);
            Console.ReadLine();
        }
    }
}
