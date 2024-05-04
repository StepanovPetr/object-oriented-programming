using System.Linq;

namespace LeetCode.Easy
{
    public class NumberOfEmployeesWhoMetTarget
    {
        public int NumberOfEmployeesWhoMetTargetResult(int[] hours, int target)
        {
            var result = hours.Count(i => i >= target);
            return result;
        }
    }
}