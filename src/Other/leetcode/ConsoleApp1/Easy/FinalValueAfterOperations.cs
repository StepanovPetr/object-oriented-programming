namespace LeetCode.Easy
{
    public class FinalValueAfterOperations
    {
        public int FinalValueAfterOperationsResult(string[] operations)
        {
            var x = 0;
            foreach (var operation in operations)
            {
                x = operation.Contains("++")
                    ? x + 1
                    : x - 1;
            }

            return x;
        }
    }
}