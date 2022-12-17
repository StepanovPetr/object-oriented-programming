using LibExample.Example.Buildings;
using LibExample.Example.Heroes;
using LibExample.Example.Units;

namespace LibExample.Example.Factories
{
    public class AllianceFactory : IFactory
    {
        public IBuilding CreateBuilding()
        {
            return new TownHall();
        }

        public IHero CreateHero()
        {
            return new ArchMage();
        }

        public IUnit CreateUnit()
        {
            return new Footman();
        }
    }
}
