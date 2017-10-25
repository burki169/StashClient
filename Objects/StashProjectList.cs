using System;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class StashProjectList
    {
        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("values")]
        public Project[] Projects { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashProjectList FromJson(string json) => JsonConvert.DeserializeObject<StashProjectList>(json, Converter.Settings);
    }
    
}
