using System;

// В C# допустимо множественное наследование только от интерфейсов.
// Множественное наследование реализации (т.е. от двух и более классов или структур) недопустимо.
// Допустимо множественное наследование от одного класса и многих интерфейсов.

namespace lesson3
{
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }
}
