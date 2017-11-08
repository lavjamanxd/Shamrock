using GalaSoft.MvvmLight;

namespace Shamrock.Core.Services.Interfaces
{
    public interface INavigationService
    {
        void InitialNavigation();
        void Navigate(object modelToNavigate);
        void NavigateBack();
    }
}