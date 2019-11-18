using builder.Abstractions;
using builder.Implementations;

namespace builder.Directors
{
    public class Barista
    {
        public Barista(CoffeMachine coffeMachine)
        {
            _coffeMachine = coffeMachine;
        }

        private readonly CoffeMachine _coffeMachine;

        public void Build()
        {
            _coffeMachine.AddWater();
            _coffeMachine.AddBeans();
            _coffeMachine.AddMilk();
        }
    }
}
