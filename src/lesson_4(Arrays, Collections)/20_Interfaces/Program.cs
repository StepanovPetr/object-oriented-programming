using LibExample;
using LibExample.implementation;

namespace _20_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var enumeratorExample = new EnumerableExample();

            foreach (Man item in enumeratorExample)
            {
                Console.WriteLine(item.ManInfo());
            }
        }
    }
}
