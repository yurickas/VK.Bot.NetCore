using System.Threading.Tasks;
using Refit;
using Vk.Bot.NetCore.Models;

namespace Vk.Bot.NetCore.Api
{
    public interface IVkBotApi
    {
        [Get("/messages.send")]
        Task<ApiResponse<dynamic>> SendMessageAsync([Query] VkSendMessageParameters param);
    }
}