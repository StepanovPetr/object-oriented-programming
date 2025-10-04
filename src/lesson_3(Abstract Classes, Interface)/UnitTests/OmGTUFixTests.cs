using LibExample.DependencyInjection;
using LibExample.DependencyInjection2;
using Moq;
using NUnit.Framework;


namespace UnitTests
{
    [TestFixture]
    internal class OmGTUFixTests
    {
        [TestCase(1, false)]
        [TestCase(7, false)]
        [TestCase(8, true)]
        [TestCase(10, true)]
        [TestCase(23, false)]
        public void OmGTUFixTests_IsOpen(int hour, bool result)
        {
            // Arrange.
            Mock<IDateTimeManager> departmentMock = new();
            departmentMock.Setup(m => m.GetDateTimeNow())
                .Returns(new System.DateTime(2025, 12, 3, hour, 4, 5)
                {
                    
                });

            OmGTUFix omgtu = new OmGTUFix(departmentMock.Object);

            // Act.
            var realResult =  omgtu.IsOpen();

            //Assert.
            Assert.That(realResult, Is.EqualTo(result));
        }

    }
}
