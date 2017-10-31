using System.Threading.Tasks;
using RestEase;
using Shamrock.Core._4Chan.Model;

namespace Shamrock.Core._4Chan.API
{
    [Header("User-Agent", "Shamrock")]
    public interface I4ChanImageApi
    {
        [Get("{board}/{timestamp}.{extension}")]
        Task<Catalog> GetImage([Path] string board, [Path] string timestamp, [Path] string extension);
    }
}