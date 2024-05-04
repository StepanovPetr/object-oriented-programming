using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    public class KidsWithCandies
    {
        public IList<bool> KidsWithCandiesResult(int[] candies, int extraCandies)
        {
            var max = candies.Max();
            var result = new List<bool>();

            foreach (var candy in candies)
            {
                result.Add(candy + extraCandies >= max);
            }
            return result;
        }
    }
}