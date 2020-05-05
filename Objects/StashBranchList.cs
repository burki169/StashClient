using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashClient.Objects
{
    public partial class StashBranchList
    {

        [JsonProperty("isLastPage")]
        public bool IsLastPage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("values")]
        public Branch[] Branches { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        public static StashBranchList FromJson(string json) => JsonConvert.DeserializeObject<StashBranchList>(json, Converter.Settings);

    }
}
