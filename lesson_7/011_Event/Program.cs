using System;

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/add
// События.
namespace Events
{
    /*
    Контекстное ключевое слово add определяет метод доступа настраиваемого события, 
    который вызывается, когда клиентский код подписывается на событие. 
    Если указан настраиваемый метод доступа add, также необходимо указать метод доступа remove.
     */
    public delegate void EventDelegate();

    public class MyClass
    {
        event EventDelegate sessionStart = null;

        public event EventDelegate SessionStart
        {
            add {
                if (!value.Method.Name.Contains("Bad"))
                    sessionStart += value;
                }
            remove { SessionStart -= value; }
        }

        public void InvokeEvent()
        {
            sessionStart.Invoke();
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void GoodHandler1()
        {
            Console.WriteLine("Начинать учить.");
        }

        static private void GoodHandler2()
        {
            Console.WriteLine("Появиться в универе.");
        }

        static private void BadHandler1()
        {
            Console.WriteLine("Учить устав.");
        }

        static private void BadHandler2()
        {
            Console.WriteLine("Написать заявление на отчисление");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.SessionStart += BadHandler2;
            instance.SessionStart += BadHandler1;
            instance.SessionStart += GoodHandler1;

            ///instance.HitTheWater.Invoke();
            // Метод который вызывает событие.
            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
