
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Links
    {
        [JsonProperty("clone")]
        public Clone[] Clone { get; set; }

        [JsonProperty("self")]
        public Self[] Self { get; set; }
    }

}
