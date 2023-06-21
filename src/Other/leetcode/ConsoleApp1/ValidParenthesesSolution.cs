using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            if (s.Length % 2 != 0)
            {
                return false;
            }

            foreach (var t in s)
                if (t == '(' || t == '{' || t == '[')
                {
                    stack.Push(t);
                }
                else
                {
                    if (t == ')')
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;

                    if (t == '}')
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;

                    if (t == ']')
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                }

            return stack.Count == 0;
        }
    }
}