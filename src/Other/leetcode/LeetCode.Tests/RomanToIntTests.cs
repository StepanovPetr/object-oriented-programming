using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class RomanToIntTests
    {
        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void RomanToIntTest(string str, int expectedResult)
        {
            // Arrange.
            var twoSumSolution = new RomanToIntSolution();

            // Act.
            var result = twoSumSolution.RomanToInt(str);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
