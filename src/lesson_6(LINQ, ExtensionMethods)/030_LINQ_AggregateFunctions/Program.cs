using LibExample;

namespace _030_LINQ_AggregateFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var result = persons.Min(i => i.Age);
            Console.WriteLine(result);

            result = persons.Max(i => i.Age);
            Console.WriteLine(result);

            result = persons.Sum(i => i.Age);
            Console.WriteLine(result);

            var resultAverage = persons.Average(i => i.Age);
            Console.WriteLine(resultAverage);

            result = persons.Count();
            Console.WriteLine(result);

            result = persons.Count(i => i.Age >= 25);
            Console.WriteLine(result);
        }
    }
}
