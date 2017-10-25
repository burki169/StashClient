
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class OtherLinks
    {
        [JsonProperty("self")]
        public Self[] Self { get; set; }
    }

    

    

}
