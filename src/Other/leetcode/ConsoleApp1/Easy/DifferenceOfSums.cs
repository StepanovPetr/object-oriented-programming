namespace LeetCode.Easy
{
    public class DifferenceOfSums
    {
        public int DifferenceOfSumsResult(int n, int m)
        {
            var value1 = 0;
            var value2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0)
                {
                    value1 += i;
                }
                else
                {
                    value2 += i;
                }
            }

            return value1 - value2;
        }
    }
}