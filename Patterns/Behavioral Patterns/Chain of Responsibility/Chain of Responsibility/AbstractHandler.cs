namespace Chain_of_Responsibility
{
    public abstract class AbstractHandler
    {
        public AbstractHandler NextHandler { get; private set; }

        public void SetNext(AbstractHandler handler)
        {
            NextHandler = handler;
        }

        public abstract bool Handle(Student request);
    }
}