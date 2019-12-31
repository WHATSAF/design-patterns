using System;
using decorator.Abstractions;

namespace decorator.Implementations
{
    public class Marlboro : BulletBase
    {
        public Marlboro(IESmoking eSmoking) : base(eSmoking)
        {
        }

        public override void Smoke()
        {
            ESmoking.Show();

            Console.WriteLine("I'm iqos with marlboro bullet.");
        }
    }
}
