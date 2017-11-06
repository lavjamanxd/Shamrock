using Shamrock.Core._4Chan.API;

namespace Shamrock.Core.Services.Interfaces
{
    public interface IBackend
    {
        I4ChanApi Api { get; }
        I4ChanImageApi ImageApi { get; }
        I4ChanThumbnailApi ThumbnailApi { get; }
    }
}