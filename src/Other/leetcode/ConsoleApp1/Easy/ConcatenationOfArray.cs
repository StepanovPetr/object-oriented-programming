using System.Linq;

namespace LeetCode.Easy
{
    public class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            var result = new int[nums.Length * 2];
            var count = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[count + i] = nums[i];
            }

            return result;
        }
    }
}