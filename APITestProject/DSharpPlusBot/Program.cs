using DSharpPlus;
using System;
using System.Threading.Tasks;

namespace DSharpPlusBot
{
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "MTA3OTg0NjQ4OTQzNTY4NTAwOQ.Gjrzl7.fBeziEa-IzmuUIKcuZiYUeSe9U98a-cacsGH4U",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("omega"))
                    await e.Message.RespondAsync("is a bitch");
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
