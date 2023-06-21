using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class LengthOfLastWordSolutionTests
    {
        [TestCase("Hello World", 5)]
        [TestCase("   fly me   to   the moon  ", 4)]
        [TestCase("luffy is still joyboy", 6)]

        public void LengthOfLastWorTest(string str,  int expectedResult)
        {
            // Arrange.
            var twoSumSolution = new LengthOfLastWordSolution();

            // Act.
            var result = twoSumSolution.LengthOfLastWord(str);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
