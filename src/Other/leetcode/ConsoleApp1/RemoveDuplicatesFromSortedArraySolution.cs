using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArraySolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var distinctNums = nums.ToList().Distinct().ToArray();
            //nums = distinctNums.ToArray();
            for (var i = 0; i < distinctNums.Length; i++) 
                nums[i] = distinctNums[i];

            for (var i = distinctNums.Length; i < nums.Length; i++) 
                nums[i] = 0;

            return distinctNums.Length;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int coutVal = 0;
            int masCount = nums.Length;
            var numsLength = nums.Length;

            for (var i = 0; i < numsLength; )
            {
                if (nums[i] == val)
                {
                    var temp = nums[i];
                    nums[i] = nums[numsLength -1];
                    nums[numsLength -1] = temp;
                    numsLength--;
                    coutVal++;
                }
                else
                {
                    i++;
                }
            }
            return masCount - coutVal;
        }
    }
}