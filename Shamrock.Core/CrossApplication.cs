using MicroResolver;

namespace Shamrock.Core
{
    public abstract class CrossApplication
    {
        private ObjectResolver _resolver;

        public void InitializeContainer()
        {
            _resolver = ObjectResolver.Create();
            RegisterCommonComponents();
            RegisterPlatformParts();
            _resolver.Compile();
        }

        public void RegisterCommonComponents()
        {
        }

        public abstract void RegisterPlatformParts();
    }
}
