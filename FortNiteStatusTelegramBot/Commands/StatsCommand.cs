using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatusTelegramBot.Commands
{
    internal sealed class StatsCommand : BaseCommand
    {
        public StatsCommand(IFortNiteTrackerApi client)
            : base(client)
        { }

        public async override Task<string> Handle(string args, Message message)
        {
            if (string.IsNullOrWhiteSpace(args))
                return $"You must specify at least player nick: {message.Text} nickname";
            else
            {
                var argsParts = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var playerPerPlatform = await GetPlayerFromArgs(argsParts);
                if (playerPerPlatform.Length == 0)
                    return $"Player *{argsParts[0]} was not found*";
                else
                    foreach (var player in playerPerPlatform)
                        return CreatePlayerStatsMessage(player);
            }
            return null;
        }

        private string CreatePlayerStatsMessage(FortNitePlayer player)
        {
            var sb = new StringBuilder();
            foreach (var item in player.lifeTimeStats.Skip(7))
                sb.AppendLine($"{item.key}: {item.value}");

            return $"The *{player.epicUserHandle}'s* stats on *{player.platformNameLong}* is:{Environment.NewLine}{sb}";
        }
    }
}
