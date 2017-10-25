
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class StashRepositoryFileList
    {
        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("nextPageStart")]
        public long? NextPageStart { get; set; }

        [JsonProperty("values")]
        public string[] Files { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashRepositoryFileList FromJson(string json) => JsonConvert.DeserializeObject<StashRepositoryFileList>(json, Converter.Settings);
    }
    
}
