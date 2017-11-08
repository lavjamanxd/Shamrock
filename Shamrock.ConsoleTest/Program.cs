using System;
using GalaSoft.MvvmLight;
using Shamrock.Core;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core.Util;
using Shamrock.Core.ViewModel;

namespace Shamrock.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootStrap = new BootstrapConsole();
            bootStrap.Start();
            Console.ReadKey();
        }
    }

    public class BootstrapConsole : Bootstrap
    {
        public override void RegisterPlatformParts()
        {
            Resolver.Register<INavigationService, NavigationService>();
        }
    }

    public class NavigationService : NavigationServiceBase
    {
        public override void NavigateBack()
        {

        }

        protected override void NavigateTo(CommonViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
