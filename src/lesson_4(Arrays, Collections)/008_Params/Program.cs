using System;

namespace _008_Params
{
    class Program
    {
        static void Main(string[] args)
        {
             ParamsExample(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
             Console.ReadLine();
        }

        private static void ParamsExample(params int[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
