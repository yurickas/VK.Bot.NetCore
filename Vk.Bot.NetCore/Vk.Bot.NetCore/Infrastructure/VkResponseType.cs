namespace Vk.Bot.NetCore.Infrastructure
{
    public static class VkResponseType
    {
        /// <summary>
        /// Подтверждение запроса сервера
        /// </summary>
        public const string Confirmation = "confirmation";
        /// <summary>
        /// входящее сообщение
        /// </summary>
        public const string MessageNew = "message_new";
        /// <summary>
        /// новое исходящее сообщение
        /// </summary>
        public const string MessageReply = "message_reply";
        /// <summary>
        /// редактирование сообщения
        /// </summary>
        public const string MessageEdit = "message_edit";
        /// <summary>
        /// подписка на сообщения от сообщества
        /// </summary>
        public const string MessageAllow = "message_allow";
        /// <summary>
        /// новый запрет сообщений от сообщества
        /// </summary>
        public const string MessageDeny = "message_deny";
        /// <summary>
        /// статус набора текста
        /// </summary>
        public const string MessageTypingState = "message_typing_state";
        /// <summary>
        /// действие с сообщением. Используется для работы с Callback-кнопками
        /// </summary>
        public const string MessageEvent = "message_event";
        /// <summary>
        /// добавление фотографии
        /// </summary>
        public const string PhotoNew = "photo_new";
        /// <summary>
        /// добавление комментария к фотографии
        /// </summary>
        public const string PhotoCommentNew = "photo_comment_new";
        /// <summary>
        /// редактирование комментария к фотографии
        /// </summary>
        public const string PhotoCommentEdit = "photo_comment_edit";
        /// <summary>
        /// восстановление комментария к фотографии
        /// </summary>
        public const string PhotoCommentRestore = "photo_comment_restore";
        /// <summary>
        /// удаление комментария к фотографии
        /// </summary>
        public const string PhotoCommentDelete = "photo_comment_delete";
        /// <summary>
        /// добавление аудио
        /// </summary>
        public const string AudioNew = "audio_new";
        /// <summary>
        /// добавление видео
        /// </summary>
        public const string VideoNew = "video_new";
        /// <summary>
        /// комментарий к видео
        /// </summary>
        public const string VideoCommentNew = "video_comment_new";
        /// <summary>
        /// редактирование комментария к видео
        /// </summary>
        public const string VideoCommentEdit = "video_comment_edit";
        /// <summary>
        /// восстановление комментария к видео
        /// </summary>
        public const string VideoCommentRestore = "video_comment_restore";
        /// <summary>
        /// удаление комментария к видео
        /// </summary>
        public const string VideoCommentDelete = "video_comment_delete";
        /// <summary>
        /// запись на стене
        /// </summary>
        public const string WallPostNew = "wall_post_new";
        /// <summary>
        /// репост записи из сообщества
        /// </summary>
        public const string WallRepost = "wall_repost";
        /// <summary>
        /// добавление комментария на стене
        /// </summary>
        public const string WallReplyNew = "wall_reply_new";
        /// <summary>
        /// редактирование комментария на стене
        /// </summary>
        public const string WallReplyEdit = "wall_reply_edit";
        /// <summary>
        /// восстановление комментария на стене
        /// </summary>
        public const string WallReplyRestore = "wall_reply_restore";
        /// <summary>
        /// удаление комментария на стене
        /// </summary>
        public const string WallReplyDelete = "wall_reply_delete";
        /// <summary>
        /// Событие о новой отметке "Мне нравится"
        /// </summary>
        public const string LikeAdd = "like_add";
        /// <summary>
        /// Событие о снятии отметки "Мне нравится"
        /// </summary>
        public const string LikeRemove = "like_remove";
        /// <summary>
        /// создание комментария в обсуждении
        /// </summary>
        public const string BoardPostNew = "board_post_new";
        /// <summary>
        /// редактирование комментария
        /// </summary>
        public const string BoardPostEdit = "board_post_edit";
        /// <summary>
        /// восстановление комментария
        /// </summary>
        public const string BoardPostRestore = "board_post_restore";
        /// <summary>
        /// удаление комментария в обсуждении
        /// </summary>
        public const string BoardPostDelete = "board_post_delete";
        /// <summary>
        /// новый комментарий к товару
        /// </summary>
        public const string MarketCommentNew = "market_comment_new";
        /// <summary>
        /// редактирование комментария к товару
        /// </summary>
        public const string MarketCommentEdit = "market_comment_edit";
        /// <summary>
        /// восстановление комментария к товару
        /// </summary>
        public const string MarketCommentRestore = "market_comment_restore";
        /// <summary>
        /// удаление комментария к товару
        /// </summary>
        public const string MarketCommentDelete = "market_comment_delete";
        /// <summary>
        /// новый заказ
        /// </summary>
        public const string MarketOrderNew = "market_order_new";
        /// <summary>
        /// редактирование заказа
        /// </summary>
        public const string MarketOrderEdit = "market_order_edit";

    }
}