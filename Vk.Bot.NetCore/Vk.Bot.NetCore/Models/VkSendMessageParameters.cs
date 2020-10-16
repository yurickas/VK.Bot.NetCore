using System;
using Newtonsoft.Json;
using Refit;

namespace Vk.Bot.NetCore.Models
{
    public class VkSendMessageParameters: VkParametersBase
    {
        /// <summary>
        /// идентификатор пользователя, которому отправляется сообщение
        /// </summary>
        [JsonProperty("user_id")]
        [AliasAs("user_id")]
        public int? UserID { get; set; }

        /// <summary>
        /// уникальный (в привязке к API_ID и ID отправителя) идентификатор, предназначенный для предотвращения повторной отправки одинакового сообщения.
        /// Сохраняется вместе с сообщением и доступен в истории сообщений.
        /// </summary>
        [JsonProperty("random_id")]
        [AliasAs("random_id")]
        public int? RandomID { get; set; }

        /// <summary>
        /// идентификатор назначения.
        /// </summary>
        [JsonProperty("peer_id")]
        [AliasAs("peer_id")]
        public int? PeerID { get; set; }

        /// <summary>
        /// короткий адрес пользователя (например, illarionov).
        /// </summary>
        [JsonProperty("domain")]
        [AliasAs("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// идентификатор беседы, к которой будет относиться сообщение.
        /// </summary>
        [JsonProperty("chat_id")]
        [AliasAs("chat_id")]
        public int? ChatID { get; set; }

        /// <summary>
        /// идентификаторы получателей сообщения (при необходимости отправить сообщение сразу нескольким пользователям).
        /// Доступно только для ключа доступа сообщества. Максимальное количество идентификаторов: 100.
        /// </summary>
        [JsonProperty("user_ids")]
        [AliasAs("user_ids")]
        public string UserIds { get; set; }

        /// <summary>
        /// текст личного сообщения. Обязательный параметр, если не задан параметр attachment.
        /// </summary>
        [JsonProperty("message")]
        [AliasAs("message")]
        public string Message { get; set; }

        /// <summary>
        /// географическая широта (от -90 до 90).
        /// </summary>
        [JsonProperty("lat")]
        [AliasAs("lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// географическая долгота (от -180 до 180).
        /// </summary>
        [JsonProperty("long")]
        [AliasAs("long")]
        public double? Long { get; set; }

        /// <summary>
        /// медиавложения к личному сообщению, перечисленные через запятую.
        /// </summary>
        [JsonProperty("attachment")]
        [AliasAs("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// идентификатор сообщения, на которое требуется ответить.
        /// </summary>
        [JsonProperty("reply_to")]
        [AliasAs("reply_to")]
        public int? ReplyTo { get; set; }

        /// <summary>
        /// идентификаторы пересылаемых сообщений, перечисленные через запятую. Перечисленные сообщения отправителя будут отображаться в теле письма у получателя.
        /// Не более 100 значений на верхнем уровне, максимальный уровень вложенности: 45, максимальное количество пересылаемых сообщений 500
        /// </summary>
        [JsonProperty("forward_messages")]
        [AliasAs("forward_messages")]
        public string ForwardMessages { get; set; }

        /// <summary>
        /// идентификатор стикера.
        /// </summary>
        [JsonProperty("sticker_id")]
        [AliasAs("sticker_id")]
        public int? StickerID { get; set; }

        /// <summary>
        /// идентификатор сообщества (для сообщений сообщества с ключом доступа пользователя).
        /// </summary>
        [JsonProperty("group_id")]
        [AliasAs("group_id")]
        public int? GroupID { get; set; }

        /// <summary>
        /// 1 — не создавать сниппет ссылки из сообщения.
        /// флаг, может принимать значения 1 или 0, по умолчанию
        /// </summary>
        [JsonProperty("dont_parse_links")]
        [AliasAs("dont_parse_links")]
        public int? DontParseLinks { get; set; }

        /// <summary>
        /// 1 - отключить уведомление об упоминании в сообщении
        /// </summary>
        [JsonProperty("disable_mentions")]
        [AliasAs("disable_mentions")]
        public int? DisableMentions { get; set; }

        public VkSendMessageParameters()
        {
            RandomID = new Random().Next();
        }
    }
}