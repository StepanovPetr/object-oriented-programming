using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            Stack<char> longStack = new Stack<char>();
            Stack<char> shortStack = new Stack<char>();
            var result = "";
            var flag = 0;

            if (a.Length >= b.Length)
            {
                foreach (var item in a)
                {
                    longStack.Push(item);
                }

                foreach (var item in b)
                {
                    shortStack.Push(item);
                }
            }
            else
            {
                foreach (var item in b)
                {
                    longStack.Push(item);
                }

                foreach (var item in a)
                {
                    shortStack.Push(item);
                }
            }

            while (longStack.Count != 0)
            {
                int temp;
                var firstChar = int.Parse(longStack.Pop().ToString());
                temp = firstChar + flag;
                flag = 0;

                if (shortStack.Count != 0)
                {
                    var secondChar = int.Parse(shortStack.Pop().ToString());
                    temp += secondChar;
                }

                switch (temp)
                {
                    case 0: result += "0"; break;
                    case 1: result += "1";
                        break;
                    case 2:
                        result += "0";
                        flag = 1; break;
                    case 3:
                        result += "1";
                        flag = 1; break;
                }
            }

            if (flag != 0)
            {
                result += "1";
            }

            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}