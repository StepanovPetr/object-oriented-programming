using LeetCode.Common.Factories;
using LeetCode.Normal;
using NUnit.Framework;

namespace LeetCode.Tests.Normal
{
    [TestFixture]
    public class AddTwoNumbersTests
    {
        [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbersTests1(int[] nums, int[] nums2, int[] expectedResult)
        {
            // Arrange.
            var addTwoNumbers = new AddTwoNumbers();

            var list1 = ListNodeFactory.FactoryMethod(nums);
            var list2 = ListNodeFactory.FactoryMethod(nums2);

            // Act.
            var result = addTwoNumbers.AddTwoNumbersResult(list1, list2);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}