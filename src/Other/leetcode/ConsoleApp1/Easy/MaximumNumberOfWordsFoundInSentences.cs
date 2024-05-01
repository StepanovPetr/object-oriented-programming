using System.Linq;

namespace LeetCode.Easy
{
    public class MaximumNumberOfWordsFoundInSentences
    {
        public int MostWordsFound(string[] sentences)
        {
            var result = 0;

            foreach (var sentence in sentences)
            {
                var item = sentence.Count(s => s == ' ');
                item++;
                if (item > result)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}