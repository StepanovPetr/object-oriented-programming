using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class ValidParenthesesSolutionTests
    {
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("{[]}", true)]
        [TestCase("]", false)]
        [TestCase("){", false)]
        public void ValidParenthesesSolutionTest(string str,  bool expectedResult)
        {
            // Arrange.
            var twoSumSolution = new ValidParenthesesSolution();

            // Act.
            var result = twoSumSolution.IsValid(str);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
