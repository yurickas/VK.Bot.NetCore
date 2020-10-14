using System;
using Microsoft.Extensions.DependencyInjection;
using Vk.Bot.NetCore.Infrastructure;

namespace Vk.Bot.NetCore.Middleware
{
    public static class VkApiExtentions
    {
        public static IServiceCollection AddVkBot(this IServiceCollection services, Action<VkBotConfiguration> action)
        {
            var conf = new VkBotConfiguration();

            action.Invoke(conf);

            services.AddSingleton(conf);


            return services;
        }
    }
}