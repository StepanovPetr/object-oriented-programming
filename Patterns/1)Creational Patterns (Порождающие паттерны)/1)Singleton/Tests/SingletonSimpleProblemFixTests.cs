using System.Threading;
using System.Threading.Tasks;
using LibExample;
using NUnit.Framework;

namespace Tests
{
    [TestFixture(TestName = "Тесты для класса SingletonSimpleProblemFix.")]
    public class SingletonSimpleProblemFixTests
    {
        [TestCase(TestName = "HashCode нескольких экземпляров созданных в одном потоке должны совпадать.")]
        public void SingletonSimpleProblemFix_OneThreadTest_HashCodesShouldEquals()
        {
            // Arrange.

            // Act.
            var instance1 = SingletonSimpleProblemFix.Instance();
            var instance2 = SingletonSimpleProblemFix.Instance();

            // Assert.
            Assert.AreEqual(instance1.GetHashCode(), instance2.GetHashCode());
        }

        [TestCase(TestName = "HashCode нескольких экземпляров созданных в разных потоках должны совпадать.")]
        public void SingletonSimpleProblemFix_AnyThreadTest_HashCodesShouldEquals()
        {
            // Arrange.
            int hashCode = 0;
            Thread thread = new Thread(t => hashCode = SingletonSimpleProblemFix.Instance().GetHashCode());

            // Act.
            thread.Start();
            thread.Join();
            var instance2 = SingletonSimpleProblemFix.Instance();
            var hashCode2 = instance2.GetHashCode();

            // Assert.
            Assert.AreEqual(hashCode, hashCode2);
        }

        [TestCase(TestName = "HashCode нескольких экземпляров созданных в разных задачах должны совпадать.")]
        public async Task SingletonSimpleProblemFix_AnyTaskTest_HashCodesShouldEqualsAsync()
        {
            // Arrange.
            var hashCode = await Task.Run(() => SingletonSimpleProblemFix.Instance().GetHashCode());

            // Act.
            var instance2 = SingletonSimpleProblemFix.Instance();
            var hashCode2 = instance2.GetHashCode();

            // Assert.
            Assert.AreEqual(hashCode, hashCode2);
        }
    }
}
