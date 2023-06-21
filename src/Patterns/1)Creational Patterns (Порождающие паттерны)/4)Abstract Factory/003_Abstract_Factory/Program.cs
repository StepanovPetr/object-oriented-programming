using System;
using LibExample.Example.Buildings;
using LibExample.Example.Factories;
using LibExample.Example.Heroes;
using LibExample.Example.Units;

namespace _003_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new HordeFactory();

            IUnit unit = factory.CreateUnit();
            IBuilding  building = factory.CreateBuilding();
            IHero hero = factory.CreateHero();

            Console.WriteLine(unit.Name);
            Console.WriteLine(building.Name);
            Console.WriteLine(hero.Name);

            Console.ReadLine();
        }
    }
}
