namespace LeetCode.Easy
{
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];
            int start = 1;
            int end = n;

            result[0] = nums[0];
            for (int i = 1; i < result.Length; i++)
            {
                if ( i % 2 != 0)
                {
                    result[i] = nums[end];
                    end++;
                }
                else
                {
                    result[i] = nums[start];
                    start++;
                }
            }

            return result;
        }
    }
}