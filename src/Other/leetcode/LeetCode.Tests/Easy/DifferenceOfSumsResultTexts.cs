using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Tests.Easy
{
    public class DifferenceOfSumsResultTexts
    {

        [TestCase(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
        [TestCase(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
        public void DifferenceOfSumsResultTextsTests(int[] nums, int[] expectedResult)
        {
            // Arrange.
            var array = new BuildArrayFromPermutation();

            // Act.
            var result = array.BuildArray(nums);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}