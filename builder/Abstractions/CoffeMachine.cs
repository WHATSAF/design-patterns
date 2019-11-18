using builder.Implementations;

namespace builder.Abstractions
{
    public abstract class CoffeMachine
    {
        protected Latte Latte = new Latte();

        public abstract void AddWater();

        public abstract void AddBeans();

        public abstract void AddMilk();

        public Latte GetLatte()
        {
            return Latte;
        }
    }
}
