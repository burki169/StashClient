
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class StashRepositoryList
    {
        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("values")]
        public Repository[] Repositories { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashRepositoryList FromJson(string json) => JsonConvert.DeserializeObject<StashRepositoryList>(json, Converter.Settings);
    }

    

    

}
