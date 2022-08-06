namespace _7_Interface
{
    public class FirstClass : IMyInterface
    {
        public int DoSomething(int param) => param * param;
    }
}