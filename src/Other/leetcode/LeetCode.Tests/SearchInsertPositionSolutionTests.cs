using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class SearchInsertPositionSolutionTests
    {
        [TestCase(new int[]{1, 3, 5, 6}, 5,2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 0, 0)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1, 3 }, 2, 1)]
        public void SearchInsert(int[] nums, int target, int expectedResult)
        {
            // Arrange.
            var searchInsertPosition = new SearchInsertPositionSolution();

            // Act.
            var result = searchInsertPosition.SearchInsert(nums, target);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
