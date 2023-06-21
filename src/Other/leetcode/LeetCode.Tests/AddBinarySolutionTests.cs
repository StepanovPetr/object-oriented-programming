using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class AddBinarySolutionTests
    {
        [TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        public void AddBinaryTest(string str, string str2, string expectedResult)
        {
            // Arrange.
            var addBinarySolution = new AddBinarySolution();

            // Act.
            var result = addBinarySolution.AddBinary(str, str2);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
