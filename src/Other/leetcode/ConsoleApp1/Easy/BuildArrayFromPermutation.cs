namespace LeetCode.Easy
{
    public class BuildArrayFromPermutation
    {
        public int[] BuildArray(int[] nums)
        {
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }
    }
}