using LibExample.Example.Buildings;
using LibExample.Example.Factories;
using LibExample.Example.Heroes;
using LibExample.Example.Units;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class HordeFactorTests
    {
        [TestCase(TestName = "Тестирование фабрики HordeFactor")]
        public void AllianceFactoryCreate_Test()
        {
            // Arrange.
            IFactory factory = new HordeFactory();

            // Act.
            IUnit unit = factory.CreateUnit();
            IBuilding building = factory.CreateBuilding();
            IHero hero = factory.CreateHero();

            //Assert.
            Assert.AreEqual(unit.Name, "Grunt");
            Assert.AreEqual(building.Name, "GreatHall");
            Assert.AreEqual(hero.Name, "BladeMaster");
        }
    }
}
