namespace LeetCode.Easy
{
    public class NumJewelsInStones
    {
        public int NumJewelsInStonesResult(string jewels, string stones)
        {
            var result = 0;
            foreach (var stone in stones)
            {
                if(jewels.Contains(stone))
                {
                    result++;
                }
            }

            return result;
        }
    }
}