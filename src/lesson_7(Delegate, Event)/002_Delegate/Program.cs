using System;
using LibExample;

/*
 Возвращаемое значение делегата.
 Экземплярный метод.
*/
namespace _002_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();

            // Пример создания делегата используя конструктор.
            MyDelegateWithInputValueAndReturnValue handler1 = new MyDelegateWithInputValueAndReturnValue(simpleClass.DelegateMethodWithReturnValue);

            // Пример предположения типа делегата.
            MyDelegateWithInputValueAndReturnValue handler2 = simpleClass.DelegateMethodWithReturnValue;

            // Пример вызова делегата.
            string resultHandler1 = handler1.Invoke("Hello word for handler1");
            // Пример вызова делегата.
            string resultHandler2 = handler2.Invoke("Hello word for handler2");

            Console.WriteLine("Результат первого делагата - {0}, Результат первого делагата - {1}", resultHandler1, resultHandler2);
            Console.ReadLine();
        }
    }
}
