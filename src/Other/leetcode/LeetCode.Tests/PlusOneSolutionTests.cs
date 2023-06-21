using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class PlusOneSolutionTests
    {
        [TestCase(new int[]{ 1, 2, 3 }, new int[] { 1, 2, 4})]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [TestCase(new int[] {9}, new int[] { 1, 0})]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]


        public void ValidParenthesesSolutionTest(int[] mas, int[] expectedResult)
        {
            // Arrange.
            var twoSumSolution = new PlusOneSolution();

            // Act.
            var result = twoSumSolution.PlusOne(mas);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}
