using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class LongestCommonPrefixTests
    {
        [TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
        [TestCase(new string[] { "dog", "racecar", "car" }, "")]
        [TestCase(new string[] { "ab", "a" }, "a")]

        public void LongestCommonPrefixTest(string[] strs, string expectedResult)
        {
            // Arrange.
            var twoSumSolution = new LongestCommonPrefixSolution();

            // Act.
            var result = twoSumSolution.LongestCommonPrefix(strs);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
