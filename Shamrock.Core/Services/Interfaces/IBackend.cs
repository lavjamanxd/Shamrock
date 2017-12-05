using System.Threading.Tasks;
using Shamrock.Core._4Chan.API;

namespace Shamrock.Core.Services.Interfaces
{
    public interface IBackend
    {
        I4ChanApi Api { get; }
        I4ChanImageApi ImageApi { get; }

        Task<byte[]> GetThumbnail(string board, string timestamp);
    }
}