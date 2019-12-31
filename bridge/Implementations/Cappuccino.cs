using System;
using bridge.Abstractions;

namespace bridge.Implementations
{
    public class Cappuccino : ICoffeType
    {
        public void Set(string size)
        {
            Console.WriteLine("You got a cup of {0} size {1} coffe.", size, "Cappuccino");
        }
    }
}
