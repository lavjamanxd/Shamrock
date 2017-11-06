using GalaSoft.MvvmLight;
using Shamrock.Core.Util;
using Shamrock.Core.ViewModel;

namespace Shamrock.Core.Services.Interfaces
{
    public abstract class NavigationServiceBase : INavigationService
    {

        public void InitialNavigation()
        {
            NavigateTo(Resolver.Construct<BoardViewModel>());
        }

        public abstract void NavigateTo(ViewModelBase viewModel);


        public abstract void NavigateBack();
    }
}