namespace _028_LINQ_AggregateFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };

            var result = scores.Min();
            Console.WriteLine(result);

            result = scores.Max();
            Console.WriteLine(result);

            result = scores.Sum();
            Console.WriteLine(result);

            var resultAverage = scores.Average();
            Console.WriteLine(resultAverage);

            result = scores.Count();
            Console.WriteLine(result);

            result = scores.Count(i => i > 0);
            Console.WriteLine(result);
        }
    }
}
