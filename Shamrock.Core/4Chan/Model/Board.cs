using Newtonsoft.Json;

namespace Shamrock.Core._4Chan.Model
{
    public class Board
    {
        [JsonProperty("board")]
        public string ShortName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ws_board")]
        public bool IsWorksafe { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("pages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("max_filesize")]
        public int MaximumFileSize { get; set; }

        [JsonProperty("max_webm_filesize")]
        public int MaximumWebMFileSize { get; set; }

        [JsonProperty("max_comment_chars")]
        public int MaximumCommentLength { get; set; }

        [JsonProperty("max_webm_duration")]
        public int MaximumWebMDuration { get; set; }

        [JsonProperty("bump_limit")]
        public int BumpLimit { get; set; }

        [JsonProperty("image_limit")]
        public int ImageLimit { get; set; }

        [JsonProperty("cooldowns")]
        public Cooldowns Cooldowns { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }
    }
}