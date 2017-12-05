using System.Net;
using System.Threading.Tasks;
using RestEase;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core._4Chan.API;

namespace Shamrock.Core.Services
{
    public class Backend : IBackend
    {
        public I4ChanApi Api { get; } = RestClient.For<I4ChanApi>("http://a.4cdn.org/");
        public I4ChanImageApi ImageApi { get; } = RestClient.For<I4ChanImageApi>("http://i.4cdn.org/");

        public async Task<byte[]> GetThumbnail(string board, string timestamp)
        {
            using (var client = new WebClient())
            {
                return await client.DownloadDataTaskAsync("http://t.4cdn.org/" + board + "/" + timestamp + "s.jpg");
            }
        }
    }
}
