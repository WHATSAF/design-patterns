using bridge.Abstractions;

namespace bridge.Implementations
{
    public class Large : CoffeBase
    {
        public override void Make()
        {
            CoffeType.Set("large");
        }
    }
}
