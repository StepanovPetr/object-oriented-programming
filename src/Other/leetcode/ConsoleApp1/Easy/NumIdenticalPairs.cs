using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    public class NumIdenticalPairs
    {
        public int NumIdenticalPairsResult(int[] nums)
        {
            var result = 0;
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(nums[i]))
                {
                    var count = nums.Count(n => n == nums[i]);
                    if (count > 1)
                    {
                        // https://practicum.yandex.ru/blog/perestanovki-razmescheniya-sochetaniya-v-analize-dannyh/#sochetanie (Сочетание)
                        var value = count * (count - 1) / 2;
                        hashSet.Add(nums[i]);
                        result += (value);
                    }
                }
            }

            return result;
        }
    }
}