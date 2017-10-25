
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class StashRepositoryFile
    {
        [JsonIgnore]
        public string Path{ get; set; }

        [JsonIgnore]
        public Repository Repository { get; set; }

        [JsonProperty("lines")]
        public Line[] Lines { get; set; }

        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashRepositoryFile FromJson(string json) => JsonConvert.DeserializeObject<StashRepositoryFile>(json, Converter.Settings);
    }

}
