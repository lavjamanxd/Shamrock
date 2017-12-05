using Shamrock.Core;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core.Util;
using Shamrock.Wpf.PlatformServices;
using Shamrock.Wpf.View.Control;

namespace Shamrock.Wpf
{
    public class BootstrapWpf : Bootstrap
    {
        private readonly ContentNavigator _navigator;

        public BootstrapWpf(ContentNavigator navigator)
        {
            _navigator = navigator;
        }

        public override void RegisterPlatformParts()
        {
            var navigationService = new NavigationService(_navigator);
            Resolver.Register<INavigationService>(navigationService);
        }
    }
}