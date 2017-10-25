
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Repository
    {
        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("forkable")]
        public bool Forkable { get; set; }

        [JsonProperty("cloneUrl")]
        public string CloneUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("scmId")]
        public string ScmId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }
    }

    

    

}
