using System;
using LibExample;

#region Links
// https://www.tutorialsteacher.com/csharp/csharp-interface
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

/* Итерфейс может содержать сигнатуры:
    1)метод (Methods);
    2)свойств (Properties;
    3)индексаторов (Indexers);
    4)событий (Events)


 Отличие интерфейса от абстрактного метода:
 1)интерфейс не может иметь модификаторов доступа к методам (public по умолчанию);
 2)интерфейс содержит только сигнатур без реализации;
 3)иинтерфейс не может иметь полей;
 4)иинтерфейс не может содержать реализации методов;
 5)Абстрактный класс может иметь конструктор, интерфейс нет;

*/

#endregion


namespace _004_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatFromInterface flat = new FlatFromInterface();
            IBuilding building = flat;
            Console.ReadLine();
        }
    }
}
