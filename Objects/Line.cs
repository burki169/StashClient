
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public partial class Line
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }



}
