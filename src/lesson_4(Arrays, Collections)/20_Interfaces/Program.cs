using LibExample;
using LibExample.Implementation;

namespace _20_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var enumeratorExample = new EnumeratorExample ();

            foreach (Man item in enumeratorExample)
            {
                Console.WriteLine(item.ManInfo());
            }
        }
    }
}
