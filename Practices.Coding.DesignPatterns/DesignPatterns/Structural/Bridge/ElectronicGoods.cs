namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Bridge
{
    public abstract class ElectronicGoods
    {
        //Composition - Implmentor
        protected IState state;

        //Alternative approach to properties:
        //we can also pass an implementor (as input argument) inside a contructor.
        //public ElectornicGoods(IState state)
        //{
        // this.state = state;
        //}

        public IState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        abstract public void MoveToCurrentState();
    }
}
