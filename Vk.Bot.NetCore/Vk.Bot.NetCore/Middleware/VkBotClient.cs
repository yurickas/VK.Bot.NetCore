using System;
using System.Net.Http;
using Newtonsoft.Json;
using Refit;
using Vk.Bot.NetCore.Api;
using Vk.Bot.NetCore.Infrastructure;

namespace Vk.Bot.NetCore.Middleware
{
    public static class VkBotClient
    {
        public static IVkBotApi RegisterVkBotClient(VkBotConfiguration conf)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.vk.com/method");

            return RestService.For<IVkBotApi>(client, new RefitSettings()
            {
                CollectionFormat = CollectionFormat.Multi,
                ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                })
            });
        }
    }
}