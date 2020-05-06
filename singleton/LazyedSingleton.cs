using System;

namespace singleton
{
    public class LazyedSingleton
    {
        private LazyedSingleton() {}

        private static Lazy<LazyedSingleton> _lazyedInstance = new Lazy<LazyedSingleton>(() =>
            new LazyedSingleton());

        public static LazyedSingleton Instance
        {
            get
            {
                return _lazyedInstance.Value;
            }
        }
    }
}
