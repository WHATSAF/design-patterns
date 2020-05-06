using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace proto
{
    [Serializable]
    public class DeepClone : ICloneable
    {
        public string MemberA { get; set; }

        public string MemberB { get; set; }

        public ReferenceModel Reference { get; set; }

        public object Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);

                return formatter.Deserialize(stream);
            }
        }
    }
}
