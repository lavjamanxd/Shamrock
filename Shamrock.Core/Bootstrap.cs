using Shamrock.Core.Services;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core.Util;

namespace Shamrock.Core
{
    public abstract class Bootstrap
    {
        private CrossApplication _crossApplication;

        private void InitializeContainer()
        {
            RegisterCommonComponents();
            RegisterPlatformParts();
        }

        private void RegisterCommonComponents()
        {
            Resolver.Register<IBackend, Backend>();
        }

        public abstract void RegisterPlatformParts();

        public void Start()
        {
            InitializeContainer();
            _crossApplication = Resolver.Construct<CrossApplication>();
        }
    }
}
