using Shamrock.Core.Services.Interfaces;
using Shamrock.Core._4Chan.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Shamrock.Core.Util;

namespace Shamrock.Core.ViewModel
{
    public class BoardListViewModel : CommonViewModel
    {
        public IEnumerable<BoardViewModel> Boards { get; private set; }

        private readonly IBackend _backend;

        public BoardListViewModel(IBackend backend)
        {
            _backend = backend;
        }

        protected override async Task LoadDataAsync(object data = null)
        {
            var boards = await _backend.Api.GetBoards();
            Boards = boards.Boards.Select(x => new BoardViewModel(_backend));
        }
    }
}
