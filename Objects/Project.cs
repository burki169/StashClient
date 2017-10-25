
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Project
    {
        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
