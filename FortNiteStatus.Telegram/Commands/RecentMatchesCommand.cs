﻿using FortNiteStatus.Core;
using FortNiteStatus.Core.Models;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatus.TelegramBot.Commands
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
                var argsParts = args.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
            sb.AppendLine("```");
            foreach (var recentmatch in player.recentMatches)
            {
                CreateHeader(sb, recentmatch);
                CreateBody(sb, recentmatch);
                sb.AppendLine("".PadLeft(45, '-'));
            }
            sb.AppendLine("```");

            return sb;
        }

        private static void CreateBody(StringBuilder sb, Recentmatch recentmatch)
        {
            if (recentmatch.matches > 1)
                sb.Append($"{recentmatch.matches} matches".PadRight(18));
            else if (recentmatch.top1 == 1)
                sb.Append($"🏆 **WINNER**".PadRight(18));
            else if (recentmatch.top3 == 1)
                sb.Append($"3️⃣ TOP 3".PadRight(18));
            else if (recentmatch.top5 == 1)
                sb.Append($"5️⃣ TOP 5".PadRight(18));
            else if (recentmatch.top6 == 1)
                sb.Append($"6️⃣ TOP 6".PadRight(18));
            else if (recentmatch.top10 == 1)
                sb.Append($"🔟 TOP 10".PadRight(18));
            else if (recentmatch.top12 == 1)
                sb.Append($"- TOP 12".PadRight(18));
            else if (recentmatch.top25 == 1)
                sb.Append($"- TOP 25".PadRight(18));
            else
                sb.Append($"🚫 Defeat".PadRight(18));

            if (recentmatch.matches > 1 && recentmatch.top1 >= 1)
                sb.Append($"🏆 {recentmatch.top1}".PadLeft(4));
            else
                sb.Append("".PadLeft(4));

            if (recentmatch.playlist == "p9")
                sb.Append($"SQUAD".PadLeft(7));
            else if (recentmatch.playlist == "p10")
                sb.Append($"DUO".PadLeft(7));
            else if (recentmatch.playlist == "p2")
                sb.Append($"SOLO".PadLeft(7));

            sb.Append($"{recentmatch.score}".PadLeft(7));
            sb.AppendLine($"{recentmatch.kills}".PadLeft(9));
        }

        private static void CreateHeader(StringBuilder sb, Recentmatch recentmatch)
        {
            sb.Append($"🕐 {recentmatch.dateCollected.Humanize()}".PadRight(18));
            if (recentmatch.matches > 1 && recentmatch.top1 >= 1)
                sb.Append("WINS".PadLeft(4));
            else
                sb.Append("".PadLeft(4));

            sb.Append("MODE".PadLeft(7));
            sb.Append("SCORE".PadLeft(7));
            sb.AppendLine("💣 KILLS".PadLeft(9));
        }
    }
}
