using LibExample;
using NUnit.Framework;

namespace _17_Nunit
{
    // Класс содержит Unit тесты.
    [TestFixture]
    public class TestExample
    {
        // Метод помечен как unit тест.
        [Test]
        public void AmperageIsTrue()
        {
            double result = ClassForUnitTesting.Amperage(50, 5);
            Assert.AreEqual(result, 10);
        }

        // Метод помечен как unit тест.
        [Test]
        public void AmperageIsFalse()
        {
            double result = ClassForUnitTesting.Amperage(60, 5);
            Assert.AreNotEqual(result, 10);
        }
    }
}
