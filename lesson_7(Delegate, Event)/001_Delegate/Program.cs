using System;

//https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/delegates/using-delegates
/*
  Делегат — это тип, который безопасно инкапсулирует метод, схожий с указателем функции в C и C++. 
  В отличие от указателей функций в C делегаты объектно-ориентированы, типобезопасны и безопасны. Тип делегата задается его именем. 
*/
namespace _001_Delegate
{
    class Program
    {
        // Пример обьявления класса длелагата.
        public delegate void MyDelegate(string message);

        // Статический метод связанный с делегатом.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            // Пример создания делегата используя конструктор.
            MyDelegate handler1 = new MyDelegate(DelegateMethod);

            // Пример предположения типа делегата.
            MyDelegate handler2 = DelegateMethod;

            // Пример вызова делегата.
            handler1.Invoke("Hello word for handler1");
            // Еше один способ вызова делегата.
            handler2("Hello World");
            Console.ReadLine();
        }
    }
}
