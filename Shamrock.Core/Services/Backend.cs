using RestEase;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core._4Chan.API;

namespace Shamrock.Core.Services
{
    public class Backend : IBackend
    {
        public I4ChanApi Api { get; } = RestClient.For<I4ChanApi>("http://a.4cdn.org/");
        public I4ChanImageApi ImageApi { get; } = RestClient.For<I4ChanImageApi>("http://i.4cdn.org/");
        public I4ChanThumbnailApi ThumbnailApi { get; } = RestClient.For<I4ChanThumbnailApi>("http://t.4cdn.org/");
    }
}
