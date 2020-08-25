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
            Assert.IsTrue(result == 10);
        }

        // Метод помечен как unit тест.
        [Test]
        public void AmperageIsfalse()
        {
            double result = ClassForUnitTesting.Amperage(60, 5);
            Assert.IsFalse(result == 10);
        }
    }
}
