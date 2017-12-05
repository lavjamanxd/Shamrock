using Shamrock.Core.Services.Interfaces;
using System.Threading.Tasks;
using Shamrock.Core._4Chan.Model;

namespace Shamrock.Core.ViewModel
{
    public class BoardListViewModel : CommonViewModel
    {
        private readonly IBackend _backend;
        private readonly INavigationService _navigationService;
        private Boards _boards;
        private Board _selectedBoard;

        public BoardListViewModel(IBackend backend, INavigationService navigationService)
        {
            _backend = backend;
            _navigationService = navigationService;
        }

        public Boards Boards
        {
            get => _boards;
            private set
            {
                _boards = value;
                RaisePropertyChanged();
            }
        }

        public Board SelectedBoard
        {
            get => _selectedBoard;
            set
            {
                _selectedBoard = value;
                RaisePropertyChanged();
                _navigationService.Navigate(_selectedBoard);
            }
        }

        protected override async Task LoadDataAsync(object data = null)
        {
            Boards = (await _backend.Api.GetBoards()).Boards;
        }
    }
}
