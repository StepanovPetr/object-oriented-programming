using LibExample;

namespace _027_LINQ_All
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };
            int[] scoresPositive = new int[] { 100, 97, 92, 81, 60 };

            var result = scores.All(i => i > 0);
            Console.WriteLine(result);

            result = scoresPositive.All(i => i > 0);
            Console.WriteLine(result);

            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            result = persons.All(m => m.City == "Омск");
            Console.WriteLine(result);
        }
    }
}
