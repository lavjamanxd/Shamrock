using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace Shamrock.Core.ViewModel
{
    public abstract class CommonViewModel : ViewModelBase
    {
        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                RaisePropertyChanged();
            }
        }

        public async Task Load(object data = null)
        {
            IsLoading = true;
            await LoadDataAsync(data);
            IsLoading = false;
        }

        protected abstract Task LoadDataAsync(object data = null);
    }
}
