using GalaSoft.MvvmLight;

namespace Shamrock.Core.Services.Interfaces
{
    public interface INavigationService
    {
        void InitialNavigation();
        void NavigateTo(ViewModelBase viewModel);
        void NavigateBack();
    }
}