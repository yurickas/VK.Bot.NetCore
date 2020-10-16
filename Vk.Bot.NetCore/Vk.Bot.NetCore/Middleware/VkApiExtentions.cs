using System;
using Microsoft.Extensions.Configuration;
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

            services.AddSingleton(VkBotClient.RegisterVkBotClient(conf));

            return services;
        }

        public static IServiceCollection AddVkBot(this IServiceCollection services, IConfiguration conf)
        {
            var section = conf.GetSection("VkBot");

            services.AddVkBot(opt =>
            {
                opt.Group = section[nameof(opt.Group)];
                opt.Key = section[nameof(opt.Key)];
                opt.ResponseKey = section[nameof(opt.ResponseKey)];
                opt.SecretKey = section[nameof(opt.SecretKey)];
                opt.VersionApi = double.Parse(section[nameof(opt.VersionApi)]);
            });

            return services;
        }
    }
}