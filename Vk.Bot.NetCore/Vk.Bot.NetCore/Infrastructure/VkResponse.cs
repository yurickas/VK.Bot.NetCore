using Newtonsoft.Json;

namespace Vk.Bot.NetCore.Infrastructure
{
    public abstract class VkResponseBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }

    
}