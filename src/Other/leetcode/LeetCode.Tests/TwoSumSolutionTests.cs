using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class IsPalindromeSolutionTests
    {
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumSolutionTest(int[] nums, int target, int[] expectedResult)
        {
            // Arrange.
            var twoSumSolution = new TwoSumSolution();

            // Act.
            var result = twoSumSolution.TwoSum(nums, target);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
