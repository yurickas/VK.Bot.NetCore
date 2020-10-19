using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Vk.Bot.NetCore.Models;

namespace Vk.Bot.NetCore.Infrastructure
{
    public class VkResponseBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [JsonIgnore]
        public VkResponseObject Object { get; set; }
        [JsonProperty("object")]
        private JObject _object {
            set
            {
                System.Type type = null;
                switch (this.Type)
                {
                    case VkResponseType.MessageNew:
                    {
                        type = typeof(VkMessageNewResponseObject);
                        break;
                    }

                    case VkResponseType.MessageEdit:
                    {
                        type = typeof(VkPrivateMessageObject);
                            break;
                    }

                    case VkResponseType.MessageReply:
                    {
                        type = typeof(VkPrivateMessageObject);
                            break;
                    }

                    case VkResponseType.MessageAllow:
                    {
                        type = typeof(VkMessageAllowResponseObject);
                        break;
                    }

                    case VkResponseType.MessageDeny:
                    {
                        type = typeof(VkMessageDenyResponseObject);
                        break;
                    }

                    default:
                        break;
                }

                Object = type != null ? (VkResponseObject) value.ToObject(type) : null;
            } }
    }
    
    
}