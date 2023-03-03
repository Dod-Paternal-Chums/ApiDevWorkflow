using DSharpPlus;
using System;
using System.Threading.Tasks;
using APITestProject.Calls;

namespace DSharpPlusBot
{
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "MTA3OTg0NjQ4OTQzNTY4NTAwOQ.Gcn6tX.hTpvXsZWet3BpbkY9qMEGJGNsPoUT9BK5R5QXA",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("labregold"))
                    await e.Message.RespondAsync(GetUsers.getBungieUser());
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
