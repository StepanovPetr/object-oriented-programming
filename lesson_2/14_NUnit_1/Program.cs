using Examle_Library;
using NUnit.Framework;

namespace NUnit_1
{
    [TestFixture]
    class Program
    {
        //Install-Package NUnit -Version 3.12.0 
        [Test]
        public void AmperageIsTrue()
        {
            double result = ExamleLibrary.Amperage(50, 5);
            Assert.IsTrue(result==10);
        }

        [Test]
        public void AmperageIsfalse()
        {
            double result = ExamleLibrary.Amperage(60, 5);
            Assert.IsFalse(result == 10);
        }
    }
}
