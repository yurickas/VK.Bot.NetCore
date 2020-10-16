namespace Vk.Bot.NetCore.Infrastructure
{
    public class VkBotConfiguration
    {
        public string Key { get; set; }
        public string Group { get; set; }
        public string ResponseKey { get; set; }
        public string SecretKey { get; set; }
        public double VersionApi { get; set; }
    }
}