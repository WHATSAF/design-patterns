using System;
using System.Collections.Generic;

namespace builder.Implementations
{
    public class Latte
    {
        private readonly List<string> _materials = new List<string>();

        public void AddMaterial(string material)
        {
            _materials.Add(material);
        }

        public void Drink()
        {
            Console.WriteLine("Yes, you have me with those:{0}", string.Join(",", _materials));
        }

    }
}
