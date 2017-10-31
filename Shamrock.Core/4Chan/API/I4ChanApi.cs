using System.Threading.Tasks;
using RestEase;
using Shamrock.Core._4Chan.Model;

namespace Shamrock.Core._4Chan.API
{
    [Header("User-Agent", "Shamrock")]
    public interface I4ChanApi
    {
        [Get("{board}/catalog.json")]
        Task<Catalog> GetCatalog([Path] string board);

        [Get("{board}/thread/{threadNumber}.json")]
        Task<Catalog> GetThreadByNumber([Path] string board, [Path] int threadNumber);

        [Get("{board}/{pageNumber}.json")]
        Task<Catalog> GetPageNumber([Path] string board, [Path] int pageNumber);

        [Get("{board}/threads.json")]
        Task<Catalog> GetThreads([Path] string board);

        [Get("{board}/archive.json")]
        Task<Catalog> GetArchivedThreads([Path] string board);

        [Get("boards.json")]
        Task<BoardInfo> GetBoards();
    }
}