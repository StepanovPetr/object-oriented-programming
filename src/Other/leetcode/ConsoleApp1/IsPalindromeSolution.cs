using System.ComponentModel.DataAnnotations;

namespace LeetCode
{
    /*
     * Given an integer x, return true if x is a palindrome, and false otherwise.
     */
    public class IsPalindromeSolution
    {
        public bool IsPalindrome(int x)
        {
            var strX = x.ToString();

            var j = strX.Length -1;

            for (int i = 0; i < strX.Length; i++)
            {
                if (strX[i] != strX[j])
                {
                    return false;
                }

                j--;
            }

            return true;
        }
    }
}
