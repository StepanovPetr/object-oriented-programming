using System;

namespace LeetCode
{
    public class RomanToIntSolution
    {
        public int RomanToInt(string s)
        {
            var result = 0;

            for (int i = 0, j = 1; i < s.Length;)
            {
                var intI = GetIntValue(s[i]);
                j = i + 1;

                if (j < s.Length)
                { 
                    var intJ = GetIntValue(s[j]);
                    if (intI >= intJ)
                    {
                        result += intI;
                        i++;
                    }
                    else
                    {
                        result += (intJ - intI);
                        i += 2;
                    }
                }

                else
                {
                    result += intI;
                    i++;
                }
            }
            return result;
        }

        private int GetIntValue(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default: throw new ArgumentException("ArgumentException");
            }
        }
    }
}