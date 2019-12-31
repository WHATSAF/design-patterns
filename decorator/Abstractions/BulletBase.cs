namespace decorator.Abstractions
{
    public abstract class BulletBase
    {
        public BulletBase(IESmoking eSmoking)
        {
            ESmoking = eSmoking;
        }

        protected readonly IESmoking ESmoking;

        public abstract void Smoke();
    }
}
