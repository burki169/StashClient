
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
