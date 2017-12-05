using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shamrock.Core._4Chan.Model;
using Shamrock.Core.Services.Interfaces;

namespace Shamrock.Core.ViewModel
{
    public class ThreadViewModel : CommonViewModel
    {
        private readonly IBackend _backend;
        private List<Thread> _threads;

        public ThreadViewModel(IBackend backend)
        {
            _backend = backend;
        }

        public Board Board { get; private set; }

        public List<Thread> Threads
        {
            get => _threads;
            private set
            {
                _threads = value;
                RaisePropertyChanged();
            }
        }

        protected override async Task LoadDataAsync(object data = null)
        {
            Board = (Board)data;
            Threads = (await _backend.Api.GetCatalog(Board.ShortName)).Select(x => x.Threads).Aggregate((x, y) => x.Concat(y)).ToList();
            Threads.ForEach(async x => await x.DownloadThumbnail(_backend, Board.ShortName));
        }
    }
}