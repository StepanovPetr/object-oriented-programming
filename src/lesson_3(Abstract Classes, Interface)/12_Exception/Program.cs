// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling

namespace _12_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string? s = null;
                Console.WriteLine(s.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключени обработано.");

                // 
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
