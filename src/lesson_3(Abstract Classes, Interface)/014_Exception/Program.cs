namespace _014_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // OutOfMemoryException
                byte[] largeArray = new byte[int.MaxValue];
            }

            catch (Exception e)
            {
                Console.WriteLine("Исключение обработано.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Namespace);
            }
        }
    }
}
