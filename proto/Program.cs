using System;

namespace proto
{
    class Program
    {
        static void Main(string[] args)
        {
            ShallowClone shallowClone = new ShallowClone
            {
                MemberA = "a",
                MemberB = "b",
                Reference = new ReferenceModel
                {
                    MemberA = "a",
                    MemberB = "b"
                }
            };

            DeepClone deepClone = new DeepClone
            {
                MemberA = "a",
                MemberB = "b",
                Reference = new ReferenceModel
                {
                    MemberA = "a",
                    MemberB = "b"
                }
            };

            var shallowObj = shallowClone.Clone() as ShallowClone;
            var deepObj = deepClone.Clone() as DeepClone;

            Console.WriteLine("source shallow: RefA->{0}", shallowClone.Reference.MemberA);
            Console.WriteLine("source deep: RefA->{0}", deepClone.Reference.MemberA);

            shallowObj.Reference.MemberA = "new a";
            deepObj.Reference.MemberA = "new a";

            Console.WriteLine("source shallow(changed): RefA->{0}", shallowClone.Reference.MemberA);
            Console.WriteLine("source deep(changed): RefA->{0}", deepClone.Reference.MemberA);

            Console.WriteLine("shallow: A->{0}, RefA->{1}", shallowObj.MemberA, shallowObj.Reference?.MemberA);
            Console.WriteLine("deep: A->{0}, RefA->{1}", deepObj.MemberA, deepObj.Reference?.MemberA);

            Console.ReadLine();
        }
    }
}
