using System;

namespace _003_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Абстрактный класс может наследовать от Абстрактного класса.
            Flat flat = new Flat();
            Building building = flat;
            Place place = building;

            Console.WriteLine(flat.GetOwner());
            Console.ReadLine();
        }
    }
}
