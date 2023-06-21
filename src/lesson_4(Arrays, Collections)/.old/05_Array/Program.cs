using System;

// Зубчатые массивы.
namespace _05_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[] { 10, 20, 30};
            array[1] = new int[] { 10, 20, 30, 40};
            array[2] = new int[] { 10, 20, 30, 40, 50};

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("[{0},{1}] - {2} ", i, j, array[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
