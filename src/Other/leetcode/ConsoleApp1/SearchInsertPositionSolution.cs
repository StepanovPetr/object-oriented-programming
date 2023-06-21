namespace LeetCode
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length;

            while (min < max)
            {
                int mid = (min + max) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target < nums[mid])
                {
                    max = mid;
                }

                if (target > nums[mid])
                {
                    min = mid+1;
                }
            }

            return  min;
        }
    }
}