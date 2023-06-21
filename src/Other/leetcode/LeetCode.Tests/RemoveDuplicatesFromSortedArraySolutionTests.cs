using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArraySolutionTests
    {
        [TestCase(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        public void RemoveDuplicatesTest(int[] mas, int[] expectedResult)
        {
            // Arrange.
            var twoSumSolution = new RemoveDuplicatesFromSortedArraySolution();

            // Act.
            var result = twoSumSolution.RemoveDuplicates(mas);

            // Assert.
            Assert.AreEqual(result, expectedResult.Length);
        }
    }
}
