using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashClient.Objects
{
    public partial class Branch
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("latestCommit")]
        public string LatestCommit { get; set; }

        [JsonProperty("latestChangeset")]
        public string LatestChangeset { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }
}
