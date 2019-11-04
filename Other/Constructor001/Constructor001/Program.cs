using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Static constractor of A class ");
        }

        public A()
        {
            Console.WriteLine("Normal constractor of A class ");
        }
    }


    public class B : A 
    {
        static B()
        {
            Console.WriteLine("Static constractor of B class ");
        }

        public B()
        {
            Console.WriteLine("Normal constractor of B class ");
        }
    }
}
