using Newtonsoft.Json;

namespace Vk.Bot.NetCore.Models
{
    public class VkMessageAllowResponseObject: VkResponseObject
    {
        /// <summary>
        /// идентификатор пользователя.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserID { get; set; }

        /// <summary>
        /// параметр, переданный в методе messages.allowMessagesFromGroup.
        /// </summary>
        [JsonProperty("key ")]
        public string Key { get; set; }
    }
}