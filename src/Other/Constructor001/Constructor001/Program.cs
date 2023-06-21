using System;

namespace Constructor001
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.ReadLine();
        }
    }

    public class A
    {
        static A()
        {
            Console.WriteLine("Static constructor of A class ");
        }

        public A()
        {
            Console.WriteLine("Normal constructor of A class ");
        }
    }

    public class B : A 
    {
        static B()
        {
            Console.WriteLine("Static constructor of B class ");
        }

        public B()
        {
            Console.WriteLine("Normal constructor of B class ");
        }
    }
}
