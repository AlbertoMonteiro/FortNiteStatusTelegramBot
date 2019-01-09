using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatusTelegramBot.Commands
{
    internal sealed class RecentMatchesCommand : BaseCommand
    {
        public RecentMatchesCommand(IFortNiteTrackerApi client)
            : base(client)
        { }

        public override async Task<string> Handle(string args, Message message)
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
                {
                    var messages = new List<string>();
                    foreach (var player in playerPerPlatform)
                    {
                        var sb = CreateRecentMatchesMessage(player);

                        messages.Add($"Listing *{player.epicUserHandle}'s* recent matches on *{player.platformNameLong}*:{Environment.NewLine}{sb}");
                    }

                    return string.Join(Environment.NewLine, messages);
                }
            }
        }

        private StringBuilder CreateRecentMatchesMessage(FortNitePlayer player)
        {
            var sb = new StringBuilder();
            foreach (var recentmatch in player.recentMatches)
            {
                if (recentmatch.matches > 1)
                    sb.Append($"{recentmatch.matches} matches ");
                else if (recentmatch.top1 == 1)
                    sb.Append($"*WINNER* ");
                else if (recentmatch.top3 == 1)
                    sb.Append($"TOP 3 ");
                else if (recentmatch.top5 == 1)
                    sb.Append($"TOP 5 ");
                else if (recentmatch.top6 == 1)
                    sb.Append($"TOP 6 ");
                else if (recentmatch.top10 == 1)
                    sb.Append($"TOP 10 ");
                else if (recentmatch.top12 == 1)
                    sb.Append($"TOP 12 ");
                else if (recentmatch.top25 == 1)
                    sb.Append($"TOP 25 ");
                else
                    sb.Append($"Defeat ");

                if (recentmatch.playlist == "p9")
                    sb.Append($"on mode SQUAD ");
                else if (recentmatch.playlist == "p10")
                    sb.Append($"on mode DUO ");
                else if (recentmatch.playlist == "p2")
                    sb.Append($"on mode SOLO ");

                if (recentmatch.matches > 1 && recentmatch.top1 >= 1)
                    sb.Append($"*with {recentmatch.top1} wins* ");

                sb.AppendLine($"and had {recentmatch.kills} kills");
            }

            return sb;
        }
    }
}
