using LibExample.Examle.Units;
using LibExample.Example.Factories;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AllianceFactoryTests
    {
        [TestCase(TestName = "Тестирование фабрики AllianceFactory")]
        public void AllianceFactoryCreate_Test()
        {
            // Arrange.
            IFactory factory = new AllianceFactory();

            // Act.
            IUnit unit = factory.CreateUnit();
            IBuilding building = factory.CreateBuilding();
            IHero hero = factory.CreateHero();

            //Assert.
            Assert.AreEqual(unit.Name, "Footman");
            Assert.AreEqual(building.Name, "TownHall");
            Assert.AreEqual(hero.Name, "ArchMage");
        }
    }
}
