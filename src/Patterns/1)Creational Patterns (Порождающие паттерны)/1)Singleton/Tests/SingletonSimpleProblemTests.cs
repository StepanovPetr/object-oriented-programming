using System.Threading;
using System.Threading.Tasks;
using LibExample;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SingletonSimpleProblemTests
    {
        [TestCase(TestName = "SingletonSimpleProblemTests HashCode нескольких экземпляров созданных в разных потоках не должны совпадать.")]
        public void SingletonSimpleProblem_AnyThreadTest_HashCodesShouldEquals()
        {
            // Arrange.
            int hashCode = 0;
            Thread thread = new Thread(t => hashCode = SingletonSimpleProblem.Instance().GetHashCode());

            // Act.
            thread.Start();
            var instance2 = SingletonSimpleProblem.Instance();
            thread.Join();
            var hashCode2 = instance2.GetHashCode();

            // Assert.
            Assert.AreNotEqual(hashCode, hashCode2);
        }

        //[TestCase(TestName = "SingletonSimpleProblemTests HashCode нескольких экземпляров созданных в разных задачах не должны совпадать.")]
        public async Task SingletonSimpleProblem_AnyTaskTest_HashCodesShouldEqualsAsync()
        {
            // Arrange.
            var hashCode = await Task.Run(() => SingletonSimpleProblem.Instance().GetHashCode());

            // Act.
            var instance2 = SingletonSimpleProblem.Instance();
            var hashCode2 = instance2.GetHashCode();

            // Assert.
            Assert.AreNotEqual(hashCode, hashCode2);
        }
    }
}
