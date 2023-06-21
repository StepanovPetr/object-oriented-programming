using System;
using System.Threading;
using System.Threading.Tasks;
using LibExample;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SingletonSimpleProblemFixTests
    {
        [TestCase(TestName = "SingletonSimpleProblemFix HashCode нескольких экземпляров созданных в разных потоках должны совпадать.") ]
        public void SingletonSimpleProblemFix_AnyThreadTest_HashCodesShouldEquals()
        {
            // Arrange.
            int hashCode = 0;
            Thread thread = new Thread(t => hashCode = SingletonSimpleProblemFix.Instance().GetHashCode());

            // Act.
            thread.Start();
            var instance2 = SingletonSimpleProblemFix.Instance();
            thread.Join();
            var hashCode2 = instance2.GetHashCode();
            
            // Assert.
            Assert.AreEqual(hashCode, hashCode2);
        }

        //[TestCase(TestName = "SingletonSimpleProblemFix HashCode нескольких экземпляров созданных в разных задачах должны совпадать.")]
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
