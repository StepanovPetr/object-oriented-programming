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
            // Arrange.

            // Act.
            double result = ClassForUnitTesting.Amperage(50, 5);
            
            // Assert.
            Assert.AreEqual(result, 10);
        }
    }
}
