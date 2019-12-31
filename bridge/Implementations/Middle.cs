using bridge.Abstractions;

namespace bridge.Implementations
{
    public class Middle : CoffeBase
    {
        public override void Make()
        {
            CoffeType.Set("middle");
        }
    }
}
