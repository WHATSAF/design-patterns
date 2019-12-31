using bridge.Abstractions;

namespace bridge.Implementations
{
    public class Small : CoffeBase
    {
        public override void Make()
        {
            CoffeType.Set("small");
        }
    }
}
