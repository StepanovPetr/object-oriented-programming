using LibExample.ExceptionExample;

namespace _11_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            throw new ExceptionExample("Вызов исключения.");

            Console.WriteLine("Hello, World!");
        }
    }
}
