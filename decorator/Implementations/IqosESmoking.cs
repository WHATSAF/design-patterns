using System;
using decorator.Abstractions;

namespace decorator.Implementations
{
    public class IqosESmoking : IESmoking
    {
        public void Show()
        {
            Console.WriteLine("I'm a good electrical smoking.");
        }
    }
}
