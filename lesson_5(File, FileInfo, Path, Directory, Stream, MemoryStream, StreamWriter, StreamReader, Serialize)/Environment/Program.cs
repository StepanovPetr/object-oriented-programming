using System;

namespace _026_Environment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Environment.OSVersion}");
            Console.WriteLine($"{Environment.MachineName}");
            Console.WriteLine($"{Environment.UserDomainName}");
            Console.WriteLine($"{Environment.UserName}");
            Console.WriteLine($"{Environment.ProcessorCount}");
            Console.WriteLine($"{Environment.Version}");
            //Console.WriteLine($"{Environment.GetLogicalDrives()}");

            var environmentVariables = Environment.GetEnvironmentVariables();

            Console.WriteLine("********************************************************************");

            foreach (var environmentVariable in environmentVariables.Keys)
            {
                Console.WriteLine($"{environmentVariable} -- {environmentVariables[environmentVariable]}");
            }

            Console.WriteLine("********************************************************************");
            Console.WriteLine($"Desktop --  {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}");
            Console.WriteLine($"MyDocuments --  {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
            Console.WriteLine($"CommonStartup --  {Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)}");
            Console.WriteLine($"Startup for Current User --  {Environment.GetFolderPath(Environment.SpecialFolder.Startup)}");

            Console.WriteLine();
        }
    }
}
