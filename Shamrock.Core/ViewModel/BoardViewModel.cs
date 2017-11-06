using GalaSoft.MvvmLight;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core._4Chan.Model;

namespace Shamrock.Core.ViewModel
{
    public class BoardViewModel : ViewModelBase
    {
        private readonly IBackend _backend;

        public BoardInfo Boards { get; set; }

        public BoardViewModel(IBackend backend)
        {
            _backend = backend;
            Boards = _backend.Api.GetBoards().Result;
        }
    }
}
