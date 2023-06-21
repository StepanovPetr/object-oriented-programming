using LibExample;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SingletonSimpleTests
    {
        [TestCase(TestName = "SingletonSimpleTests HashCode нескольких экземпляров созданных в одном потоке должны совпадать.")]
        public void SingletonSimpleProblem_OneThreadTest_HashCodesShouldEquals()
        {
            // Arrange.

            // Act.
            var instance1 = SingletonSimple.Instance();
            var instance2 = SingletonSimple.Instance();

            // Assert.
            Assert.AreEqual(instance1.GetHashCode(), instance2.GetHashCode());
        }
    }
}
