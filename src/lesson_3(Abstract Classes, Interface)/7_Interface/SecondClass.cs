namespace _7_Interface
{
    public class SecondClass : IMyInterface
    {
        int IMyInterface.DoSomething(int param) => param * param * param;
    }
}