using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashClient.Objects
{
    public partial class StashTagList
    {
        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("values")]
        public Tag[] Tags { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashTagList FromJson(string json) => JsonConvert.DeserializeObject<StashTagList>(json, Converter.Settings);

    }
}
