using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            
            BaseClass baseClass = null;
                   
            if (derivedClass is BaseClass)
            {
                baseClass = (BaseClass)derivedClass;
            }
            else
            {
                baseClass = null;
            }
            baseClass.ShowFileds();
            baseClass = null;


            baseClass = derivedClass as BaseClass;
            baseClass.ShowFileds();
            // Delay.
            Console.ReadKey();
        }
    }
}
