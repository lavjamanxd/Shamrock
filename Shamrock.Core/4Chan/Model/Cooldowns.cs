using Newtonsoft.Json;

namespace Shamrock.Core._4Chan.Model
{
    public class Cooldowns
    {
        [JsonProperty("threads")]
        public int Threads { get; set; }

        [JsonProperty("replies")]
        public int Replies { get; set; }

        [JsonProperty("images")]
        public int Images { get; set; }
    }
}