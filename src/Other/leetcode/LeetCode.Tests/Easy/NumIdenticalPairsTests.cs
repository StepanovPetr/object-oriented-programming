using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Tests.Easy
{
    public class NumIdenticalPairsTests
    {
        [TestCase(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 6)]
        public void AddTwoNumbersTests(int[] nums, int expectedResult)
        {
            // Arrange.
            var array = new NumIdenticalPairs();

            // Act.
            var result = array.NumIdenticalPairsResult(nums);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}