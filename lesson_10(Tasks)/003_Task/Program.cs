using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _003_Task
{
    internal class Program
    {
        private static bool MethodForThread(object? o)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  started");
            Console.WriteLine($"{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} finished");

            return true;
        }

        static void Main(string[] args)
        {
            Task<bool> t = new Task<bool>(MethodForThread, 6);
            t.Start();

            t.Wait();
            Console.ReadLine();
        }

        class Resolution
        {
            public int width = 1920;
            public int height = 1080;
        }

        using System;
					
        public class Program
        {

            public class A
            {
                public virtual void Print1()
                {
                    Console.Write("A");
                }
                public void Print2()
                {
                    Console.Write("A");
                }
            }
            public class B : A
            {
                public override void Print1()
                {
                    Console.Write("B");
                }
            }
            public class C : B
            {
                new public void Print2()
                {
                    Console.Write("C");
                }
            }

            public static void Main()
            {
                var c = new C();
                A a = c;

                a.Print2();
                a.Print1();
                c.Print2();
            }
        }

        public class A<T>
        {
            public static int Count { get; set; }
            public A() { Count++; }
        }
        public static void Main()
        {
            var A1 = new A<object>();
            var A2 = new A<string>();
            var A3 = new A<int>();
            Console.WriteLine(A<object>.Count);
        }


        public class Bus
        {
            static int RouteNumber { get; set; }

            static Bus()
            {
                RouteNumber = 1;
            }

            public Bus(int routeNum)
            {
                if (RouteNumber == 1)
                {

                    RouteNumber = routeNum;
                    Console.WriteLine("Bus #{0} is created.", RouteNumber);
                }

            }

            public void Drive()
            {
                Console.WriteLine("Bus #{0} drive.", RouteNumber);
            }
        }

        class TestBus
        {
            static void Main()
            {
                Bus bus1 = new Bus(71);
                Bus bus2 = new Bus(72);

                bus1.Drive();
                bus2.Drive();
            }
        }

        public bool IsEqval(string str1, string str2)
        {

           // str1 = str1.OrderBy(s => ).ToString();
           // str1 = str1.OrderBy(s => ).ToString();

           var dict = new Dictionary<char, int>();
           var dict2 = new Dictionary<char, int>();

        foreach (var s in str1)
           {
               int val;
               if (dict.TryGetValue(s, out val))
               {
                   val++;
               }
               else
               {
                   dict.Add(s,1);
               }
           }

           foreach (var s in str2)
           {
               int val;
               if (dict.TryGetValue(s, out val))
               {
                   val++;
               }
               else
               {
                   dict.Add(s, 1);
               }
           }



    }

        dog dgo -> true 
        dog dfo -> false
        doog ddog -> false

}
}
