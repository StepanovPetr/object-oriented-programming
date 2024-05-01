using System.Linq;

namespace LeetCode.Easy
{
    public class SmallerNumbersThanCurrent
    {
        public int[] SmallerNumbersThanCurrentResult(int[] nums)
        {
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var count = nums.Count(n => n < nums[i]);
                result[i] = count;
            }

            return result;
        }
    }
}