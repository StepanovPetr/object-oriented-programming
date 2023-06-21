using LeetCode.Common;
using LeetCode.Common.Factories;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Tests
{
    [TestFixture]
    public class MergeTwoSortedListsSolutionTests
    {
        [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 0 }, new int[] { 0 })]
        public void MergeTwoListsTests(int[] nums, int[] nums2, int[] expectedResult)
        {
            // Arrange.
            var twoSumSolution = new MergeTwoSortedListsSolution();

            var list1 = ListNodeFactory.FactoryMethod(nums);
            var list2 = ListNodeFactory.FactoryMethod(nums2);

            // Act.
            var result = twoSumSolution.MergeTwoLists(list1, list2);
            var list = new List<int>();
            for (var item = result; item != null; item = item.next) list.Add(item.val);

            // Assert.
            Assert.AreEqual(list.ToArray(), expectedResult);
        }

        [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbersTests(int[] nums, int[] nums2, int[] expectedResult)
        {
            // Arrange.
            var twoSumSolution = new MergeTwoSortedListsSolution();

            var list1 = ListNodeFactory.FactoryMethod(nums);
            var list2 = ListNodeFactory.FactoryMethod(nums2);

            // Act.
            var result = twoSumSolution.AddTwoNumbers(list1, list2);

            // Assert.
            Assert.AreEqual(result, expectedResult);
        }
    }
}