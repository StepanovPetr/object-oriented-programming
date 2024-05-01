namespace LeetCode.Easy
{
    public class RunningSum
    {
        public int[] RunningSumResult(int[] nums)
        {
            //var result = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    var value = 0;
            //    for (int j = 0; j <= i; j++)
            //    {
            //        value += nums[j];
            //    }
            //    result[i] = value;
            //}

            //return result;

            var result = new int[nums.Length];

            var value = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                value += nums[i];
                result[i] = value;
            }

            return result;

        }
    }
}