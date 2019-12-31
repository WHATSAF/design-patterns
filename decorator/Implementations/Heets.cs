using System;
using decorator.Abstractions;

namespace decorator.Implementations
{
    public class Heets : BulletBase
    {
        public Heets(IESmoking eSmoking) : base(eSmoking)
        {
        }

        public override void Smoke()
        {
            ESmoking.Show();

            Console.WriteLine("I'm iqos with heets bullet.");
        }
    }
}
