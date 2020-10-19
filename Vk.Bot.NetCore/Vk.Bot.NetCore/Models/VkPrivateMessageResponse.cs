using System;
using Newtonsoft.Json;

namespace Vk.Bot.NetCore.Models
{
    public class VkPrivateMessageObject: VkResponseObject
    {
        /// <summary>
        /// идентификатор сообщения.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
        /// <summary>
        /// время отправки в Unixtime.
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }
        /// <summary>
        /// идентификатор назначения.
        /// </summary>
        [JsonProperty("peer_id")]
        public int PeerID { get; set; }
        /// <summary>
        /// идентификатор отправителя.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromID { get; set; }
        /// <summary>
        /// текст сообщения.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// идентификатор, используемый при отправке сообщения. Возвращается только для исходящих сообщений.
        /// </summary>
        [JsonProperty("random_id")]
        public int RandomID { get; set; }
        /// <summary>
        /// произвольный параметр для работы с источниками переходов.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }
        /// <summary>
        /// произвольный параметр для работы с источниками переходов.
        /// </summary>
        [JsonProperty("ref_source")]
        public string RefSource { get; set; }
        /// <summary>
        /// true, если сообщение помечено как важное.
        /// </summary>
        [JsonProperty("important")]
        public bool Important { get; set; }
    }
}