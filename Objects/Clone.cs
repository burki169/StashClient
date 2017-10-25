
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Clone
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    } 



}
