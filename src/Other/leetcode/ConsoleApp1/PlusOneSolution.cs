using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var flag = false;

            for (int i = digits.Length -1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;

                    if (!flag)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                var list = new List<int>() { 1 };
                list.AddRange(digits);
                return list.ToArray();
            }
            return digits;
        }
    }
}