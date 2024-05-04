using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Tests.Easy
{
    public class ShuffleTheArrayTests
    {
        [TestCase(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [TestCase(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
        public void AddTwoNumbersTests(int[] nums, int n, int[] expectedResult)
        {
            // Arrange.
            var array = new ShuffleTheArray();

            // Act.
            var result = array.Shuffle(nums, n);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}