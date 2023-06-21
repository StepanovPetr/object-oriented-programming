using NUnit.Framework;

namespace LeetCode.Tests
{

    [TestFixture]
    public class TwoSumSolutionTests
    {
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        public void IsPalindromeSolutionTest(int num, bool expectedResult)
        {
            // Arrange.
            var isPalindromeSolution = new IsPalindromeSolution();

            // Act.
            var result = isPalindromeSolution.IsPalindrome(num);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}