namespace _017_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int n = 0;
                //var reslut = 10 / n;

                string? s = null;
                Console.WriteLine(s.Length);
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Исключение обработано.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Namespace);

                throw;
            }

            finally
            {
                Console.WriteLine("Выполнение блока finally.");
            }
        }
    }
}
