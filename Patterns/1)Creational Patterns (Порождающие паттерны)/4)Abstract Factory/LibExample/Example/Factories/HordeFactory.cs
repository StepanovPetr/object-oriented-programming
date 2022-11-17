using LibExample.Examle.Units;

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
            return new Blademaster();
        }

        public IUnit CreateUnit()
        {
            return new Grunt();
        }
    }
}
