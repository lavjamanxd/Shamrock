using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using Shamrock.Core.Services.Interfaces;

namespace Shamrock.Core._4Chan.Model
{
    public class Thread : ViewModelBase
    {
        [JsonProperty("no")]
        public int PostNumber { get; set; }

        [JsonProperty("resto")]
        public int ReplyTo { get; set; }

        [JsonProperty("sticky")]
        public bool IsSticky { get; set; }

        [JsonProperty("closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("archived_on")]
        public int ArchivedOn { get; set; }

        [JsonProperty("now")]
        public string Now { get; set; }

        [JsonProperty("time")]
        public int Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trip")]
        public string Tripcode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("capcode")]
        public string Capcode { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("sub")]
        public string Subject { get; set; }

        [JsonProperty("com")]
        public string Comment { get; set; }

        [JsonProperty("tim")]
        public string RenamedFileName { get; set; }

        [JsonProperty("filename")]
        public string OriginalFilename { get; set; }

        [JsonProperty("ext")]
        public string Extension { get; set; }

        [JsonProperty("fsize")]
        public int FileSize { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("w")]
        public int ImageWidth { get; set; }

        [JsonProperty("h")]
        public int ImageHeight { get; set; }

        [JsonProperty("tn_w")]
        public byte ThumbnailWidth { get; set; }

        [JsonProperty("tn_h")]
        public byte ThumbnailHeight { get; set; }

        [JsonProperty("filedeleted")]
        public bool IsFileDeleted { get; set; }

        [JsonProperty("spoiler")]
        public bool IsSpoiler { get; set; }

        [JsonProperty("custom_spoiler")]
        public byte CustomSpoiler { get; set; }

        [JsonProperty("omitted_posts")]
        public int NumberOfOmittedReplies { get; set; }

        [JsonProperty("omitted_images")]
        public int NumberOfOmittedImages { get; set; }

        [JsonProperty("replies")]
        public int NumberOfReplies { get; set; }

        [JsonProperty("images")]
        public int NumberOfImages { get; set; }

        [JsonProperty("bumplimit")]
        public bool IsBumpLimitMet { get; set; }

        [JsonProperty("imagelimit")]
        public bool IsImageLimitMet { get; set; }

        //[JsonProperty("capcode_replies")]
        //public List<Capcode> CapcodeReplies { get; set; }

        [JsonProperty("last_modified")]
        public int LastModified { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("semantic_url")]
        public string SemanticUrl { get; set; }

        [JsonProperty("since4pass")]
        public int ChanPassBought { get; set; }

        public async Task DownloadThumbnail(IBackend backend, string boardShortName)
        {
            Image = await backend.GetThumbnail(boardShortName, RenamedFileName);
        }

        private byte[] _image;

        public byte[] Image
        {
            get => _image;
            set
            {
                _image = value;
                RaisePropertyChanged();
            }
        }
    }
}