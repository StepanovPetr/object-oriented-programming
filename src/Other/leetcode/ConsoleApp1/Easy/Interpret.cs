namespace LeetCode.Easy
{
    public class Interpret
    {
        public string InterpretResult(string command)
        {
            return 
            command.Replace("()", "o")
                .Replace("(al)", "al");

        }
    }
}