using System;

// Класс к которуму пишем обертку.
namespace Adapter
{
    class Adaptee
    {
       public void Paint()
        {
            Console.WriteLine("***********************************************");
        }
    }
}
