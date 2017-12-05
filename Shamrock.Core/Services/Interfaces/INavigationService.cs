using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Shamrock.Core.Services.Interfaces
{
    public interface INavigationService
    {
        Task InitialNavigation();
        void Navigate(object modelToNavigate);
        void NavigateBack();
    }
}