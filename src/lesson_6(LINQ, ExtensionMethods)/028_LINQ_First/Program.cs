using LibExample;

namespace _028_LINQ_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };

            var result = scores.First();
            Console.WriteLine(result);

            result = scores.First(i => i == 0);
            Console.WriteLine(result);

            //result = scores.First(i => i == 200);
            //Console.WriteLine(result);

            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var man = persons.First( i => i.City == "Омск" );
            Console.WriteLine(man.ManInfo());

            result = scores.FirstOrDefault(i => i == 200);
            Console.WriteLine(result);

            man = persons.FirstOrDefault(i => i.City == "Минск");
            Console.WriteLine(man.ManInfo());
        }
    }
}
