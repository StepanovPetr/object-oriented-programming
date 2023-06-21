using System;
using LibExample;
using NUnit.Framework;

namespace _018_Nunit
{
    // Класс содержит Unit тесты.
    [TestFixture]
    class Program
    {
        [TestCase(5, 50, 0.1)]
        [TestCase(25, 50, 0.5)]
        [TestCase(5, 1, 5)]
        [TestCase(100, 10, 10)]
        [TestCase(125, 5, 25)]
        public void AmperageIsTrue(double electricalVoltage, double electricalResistance, double expectedresult)
        {
            double result = ClassForUnitTesting.Amperage(electricalVoltage, electricalResistance);
            Assert.IsTrue(result == expectedresult);
        }

        [TestCase(5, 50, 0.12)]
        [TestCase(25, 50, 0.35)]
        [TestCase(5, 5, 45)]
        [TestCase(100, 10, 150)]
        [TestCase(125, 5, 26)]
        public void AmperageIsFalse(double electricalVoltage, double electricalResistance, double expectedresult)
        {
            double result = ClassForUnitTesting.Amperage(60, 5);
            Assert.IsFalse(result == expectedresult);
        }
    }
}
