using LibExample;

namespace _026_LIN_Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };

            var result =  scores.Any();
            Console.WriteLine(result);

            result = scores.Any(i => i >  0);
            Console.WriteLine(result);

            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            result = persons.Any();
            Console.WriteLine(result);

            result = persons.Any(m => m.City == "Омск");
            Console.WriteLine(result);
        }
    }
}
