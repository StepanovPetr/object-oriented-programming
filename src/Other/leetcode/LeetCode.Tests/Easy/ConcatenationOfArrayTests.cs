using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Tests.Easy
{
    public class ConcatenationOfArrayTests
    {

        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1, 1, 2, 1 })]
        [TestCase(new int[] { 1, 3, 2, 1 }, new int[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
        public void AddTwoNumbersTests(int[] nums, int[] expectedResult)
        {
            // Arrange.
            var array = new ConcatenationOfArray();

            // Act.
            var result = array.GetConcatenation(nums);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}