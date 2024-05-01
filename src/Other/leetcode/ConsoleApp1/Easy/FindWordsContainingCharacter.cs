using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class FindWordsContainingCharacter
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            var list = new List<int>();
            int i = 0;

            foreach (var word in words)
            {
                if (word.Contains(x))
                {
                    list.Add(i);
                }
                i++;
            }

            return list;
        }
    }
}