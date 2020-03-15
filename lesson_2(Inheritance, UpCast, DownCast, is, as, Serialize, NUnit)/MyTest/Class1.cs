using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            int result = 4 / 2;
            Assert.IsTrue(result == 2); 
        }

    }
}
