using System;
using bridge.Abstractions;
using bridge.Implementations;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffeType cappuccino = new Cappuccino();
            Large largeCappuccino = new Large();
            largeCappuccino.SetCoffeType(cappuccino);
            largeCappuccino.Make();

            ICoffeType espresso = new Espresso();
            Small smallEspresso = new Small();
            smallEspresso.SetCoffeType(espresso);
            smallEspresso.Make();
        }
    }
}
