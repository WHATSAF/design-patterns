using System;
using abstract_factory.Abstractions;

namespace abstract_factory.Instances
{
    public class MobilePhone : IMobilePhone
    {
        public MobilePhone(string bornAt)
        {
            _bornAt = bornAt;
        }

        private readonly string _bornAt;

        public void Call()
        {
            Console.WriteLine("i can calling, i'm born at {0}", _bornAt);
        }
    }
}
