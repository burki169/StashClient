
using Newtonsoft.Json;

namespace StashClient.Objects
{
    public static class Serialize
    {
        public static string ToJson(this StashProjectList self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
