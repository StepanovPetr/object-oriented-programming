using LibExample;
using NUnit.Framework;

namespace _17_Nunit
{
    // Класс содержит Unit тесты.
    [TestFixture]
    class TestFixtureExample
    {
        [TestCase(5, 50, 0.1)]
        [TestCase(25, 50, 0.5)]
        [TestCase(5, 1, 5)]
        [TestCase(100, 10, 11)]
        [TestCase(125, 5, 25)]
        public void AmperageIsTrue(double electricalVoltage, double electricalResistance, double expectedResult)
        {
            // Arrange.

            // Act.
            double result = ClassForUnitTesting.Amperage(electricalVoltage, electricalResistance);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
