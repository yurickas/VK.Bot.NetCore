using Newtonsoft.Json;
using Refit;

namespace Vk.Bot.NetCore.Models
{
    public abstract class VkParametersBase
    {
        [JsonProperty("v")]
        [AliasAs("v")]
        public double Version { get; set; }
        [JsonProperty("access_token")]
        [AliasAs("access_token")]
        public string Key { get; set; }
    }
}