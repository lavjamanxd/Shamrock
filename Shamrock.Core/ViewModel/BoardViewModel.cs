using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Shamrock.Core._4Chan.Model;
using Shamrock.Core.Services.Interfaces;

namespace Shamrock.Core.ViewModel
{
    public class BoardViewModel : CommonViewModel
    {
        private readonly IBackend _backend;

        public BoardViewModel(IBackend backend)
        {
            _backend = backend;
        }

        public Catalog Threads { get; private set; }

        protected override async Task LoadDataAsync(object data = null)
        {
            var board = (Board)data;
            Threads = await _backend.Api.GetCatalog(board.ShortName);
        }
    }
}