using System.Linq;

namespace LeetCode
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Replace("  ", " ");
            var strs = s.Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToList();
            return strs.LastOrDefault().Length;
        }
    }
}