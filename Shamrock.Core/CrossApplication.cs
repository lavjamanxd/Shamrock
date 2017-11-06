using Shamrock.Core.Services.Interfaces;

namespace Shamrock.Core
{
    public class CrossApplication
    {
        private readonly INavigationService _navigationService;

        public CrossApplication(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.InitialNavigation();
        }
    }
}