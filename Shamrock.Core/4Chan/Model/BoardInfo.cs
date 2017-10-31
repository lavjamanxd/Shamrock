using Newtonsoft.Json;

namespace Shamrock.Core._4Chan.Model
{
    public class BoardInfo
    {
        [JsonProperty("boards")]
        public Boards Boards { get; set; }
    }
}