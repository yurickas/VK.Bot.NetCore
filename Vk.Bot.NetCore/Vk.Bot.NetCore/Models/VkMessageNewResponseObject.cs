using Newtonsoft.Json;

namespace Vk.Bot.NetCore.Models
{
    public abstract class VkResponseObject {

    }
    public class VkMessageNewResponseObject: VkResponseObject
    {
        [JsonProperty("message")]
        public VkPrivateMessageObject Message { get; set; }
        [JsonProperty("client_info")]
        public dynamic ClientInfo { get; set; }
    }

    public class VkMessageDenyResponseObject : VkResponseObject
    {
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
        [JsonProperty("user_id")]
        public int UserID { get; set; }
    }

    public class VkMessageEventResponseObject : VkMessageDenyResponseObject
    {
        /// <summary>
        /// идентификатор диалога со стороны бота
        /// </summary>
        [JsonProperty("peer_id")]
        public int PeerID { get; set; }

        /// <summary>
        /// случайная строка. Активна в течение минуты, спустя минуту становится недействительной
        /// </summary>
        [JsonProperty("event_id")]
        public string EventID { get; set; }

        /// <summary>
        /// дополнительная информация
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// идентификатор сообщения в беседе
        /// </summary>
        [JsonProperty("conversation_message_id")]
        public int ConversationMessageID { get; set; }
    }
}