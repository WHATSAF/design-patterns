using builder.Abstractions;

namespace builder.Implementations
{
    public class Starbucks : CoffeMachine
    {
        public override void AddWater()
        {
            Latte.AddMaterial("water");
        }

        public override void AddBeans()
        {
            Latte.AddMaterial("beans");
        }

        public override void AddMilk()
        {
            Latte.AddMaterial("milk");
        }
    }
}
