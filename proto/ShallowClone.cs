using System;

namespace proto
{
    public class ShallowClone : ICloneable
    {
        public string MemberA { get; set; }

        public string MemberB { get; set; }

        public ReferenceModel Reference { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
