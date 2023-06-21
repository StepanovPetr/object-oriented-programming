using LibExample.Example.Buildings;
using LibExample.Example.Heroes;
using LibExample.Example.Units;

namespace LibExample.Example.Factories
{
    public class HordeFactory : IFactory
    {
        public IBuilding CreateBuilding()
        {
            return new GreatHall();
        }

        public IHero CreateHero()
        {
            return new BladeMaster();
        }

        public IUnit CreateUnit()
        {
            return new Grunt();
        }
    }
}
