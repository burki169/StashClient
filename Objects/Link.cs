
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
