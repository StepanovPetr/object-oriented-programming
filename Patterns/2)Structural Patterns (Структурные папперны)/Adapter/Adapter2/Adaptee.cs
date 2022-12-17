using System;

// Класс к которуму пишем обертку.
namespace Adapter2
{
    class Adaptee
    {
       public void Paint()
        {
            Console.WriteLine("***********************************************");
        }
    }
}
