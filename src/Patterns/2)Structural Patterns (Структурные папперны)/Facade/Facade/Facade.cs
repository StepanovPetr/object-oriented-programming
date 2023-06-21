namespace Facade
{
    // Фосад для работы с подсистемами.
    public class Facade
    {
        private readonly SubSystemA _subSystemA;
        private readonly SubSystemB _subSystemB;
        private readonly SubSystemC _subSystemC;

        public Facade()
        {
            _subSystemA = new SubSystemA();
            _subSystemB = new SubSystemB();
            _subSystemC = new SubSystemC();
        }

        public Facade(SubSystemA subSystemA, SubSystemB subSystemB, SubSystemC subSystemС)
        {
            _subSystemA = subSystemA;
            _subSystemB = subSystemB;
            _subSystemC = subSystemС;
        }

        public void MethodA()
        {
            _subSystemA.MethodA();
            _subSystemB.MethodB();
        }

        public void MethodB()
        {
            _subSystemA.MethodA();
            _subSystemB.MethodB();
            _subSystemC.MethodC();
        }
    }
}