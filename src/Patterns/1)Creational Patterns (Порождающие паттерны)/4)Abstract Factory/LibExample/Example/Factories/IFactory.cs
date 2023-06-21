using LibExample.Example.Buildings;
using LibExample.Example.Heroes;
using LibExample.Example.Units;

namespace LibExample.Example.Factories
{
    public interface IFactory
    {
        IUnit CreateUnit();

        IBuilding CreateBuilding();

        IHero CreateHero();
    }
}
