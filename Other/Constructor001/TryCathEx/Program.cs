using System;

namespace TryCathEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new TryCatchExeption();
            try
            {
                ex.Do();
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption);
            }
            Console.ReadLine();
        }
    }

    class TryCatchExeption
    {
        public void Do()
        {
            try
            {
                var first = 1; //1
                var second = 0;//0
                var third = first / second;
            }
            catch (Exception ex)
            {
                Console.WriteLine("throw Exeption in Try");
                throw new NullReferenceException();
            }
            finally
            {
                Console.WriteLine("throw Exeption in Finally");
                throw new ArgumentException();
            }
        }

    }
}
