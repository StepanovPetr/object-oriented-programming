namespace LeetCode.Easy
{
    public class SmallestEvenMultiple
    {
        public int SmallestEvenMultipleResult(int n)
        {
            return n % 2 == 0
                ? n
                : n * 2;
        }
    }
}