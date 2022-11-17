using LibExample.Examle.Units;

namespace LibExample.Example.Factories
{
    public interface IFactory
    {
        IUnit CreateUnit();

        IBuilding CreateBuilding();

        IHero CreateHero();
    }
}
