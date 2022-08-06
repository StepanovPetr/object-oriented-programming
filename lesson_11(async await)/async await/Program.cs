using System;
using System.Threading.Tasks;
using LibExample;

namespace async_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AsyncExample.Wait();
            Console.WriteLine("Hello World!");

            await AsyncExample.WaitAsync();
            Console.ReadLine();
        }
    }
}
