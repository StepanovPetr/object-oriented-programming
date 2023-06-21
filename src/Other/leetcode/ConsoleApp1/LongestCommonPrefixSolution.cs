using System.Linq;

namespace LeetCode
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            var firstWord = strs.FirstOrDefault();
            var flag = true;

            for (var i = 0; i < firstWord.Length; i++)
            {
                var c = firstWord[i];

                foreach (var str in strs)
                    if (i >= str.Length || str[i] != c)
                        flag = false;

                if (flag)
                    result += c;
                else
                    return result;
            }

            return result;
        }
    }
}