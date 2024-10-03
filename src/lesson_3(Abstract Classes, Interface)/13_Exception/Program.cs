namespace _13_Exception
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
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Исключение обработано Деление на 0.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Namespace);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine("Исключение обработано - NullReferenceException.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Namespace);
            }
        }
    }
}
