namespace bridge.Abstractions
{
    public abstract class CoffeBase
    {
        public void SetCoffeType(ICoffeType coffeType)
        {
            CoffeType = coffeType;
        }

        protected ICoffeType CoffeType;

        public abstract void Make();
    }
}
