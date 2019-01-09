using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace FortNiteStatusTelegramBot
{
    public class CommandHandler
    {
        private readonly Dictionary<string, Func<string, Message, Task>> _commands;
        private readonly IFortNiteTrackerApi _client;
        private readonly TelegramBotClient _bot;

        public CommandHandler(TelegramBotClient bot, string trnApiKey)
        {
            _commands = new Dictionary<string, Func<string, Message, Task>>
            {
                ["stats"] = GetStats,
                ["recentmatches"] = GetLatestsMatches,
                ["help"] = GetHelp
            };
            _bot = bot;
            _client = RestService.For<IFortNiteTrackerApi>(new HttpClient(new AuthenticatedHttpClientHandler(trnApiKey)) { BaseAddress = new Uri("https://api.fortnitetracker.com") });
        }

        public Task HandleCommand(Message message, string command, string args)
            => !_commands.ContainsKey(command = command.ToLower())
                    ? _bot.SendTextMessageAsync(message.Chat, "This command is invalid", replyToMessageId: message.MessageId)
                    : _commands[command](args, message);

        #region COMMANDS
        private async Task GetStats(string args, Message message)
        {
            if (string.IsNullOrWhiteSpace(args))
                await _bot.SendTextMessageAsync(message.Chat, $"You must specify at least player nick: {message.Text} nickname", replyToMessageId: message.MessageId);
            else
            {
                var argsParts = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var playerPerPlatform = await GetPlayerFromArgs(message, argsParts);
                if (playerPerPlatform.Length == 0)
                    await _bot.SendTextMessageAsync(message.Chat, $"Player *{argsParts[0]} was not found*", ParseMode.Markdown, replyToMessageId: message.MessageId);
                else
                    foreach (var player in playerPerPlatform)
                        await AnswerWithPlayerStats(message, player.epicUserHandle, player);
            }
        }

        private async Task GetLatestsMatches(string args, Message message)
        {
            if (string.IsNullOrWhiteSpace(args))
                await _bot.SendTextMessageAsync(message.Chat, $"You must specify at least player nick: {message.Text} nickname", replyToMessageId: message.MessageId);
            else
            {
                var argsParts = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var playerPerPlatform = await GetPlayerFromArgs(message, argsParts);

                if (playerPerPlatform.Length == 0)
                    await _bot.SendTextMessageAsync(message.Chat, $"Player *{argsParts[0]} was not found*", ParseMode.Markdown, replyToMessageId: message.MessageId);
                else
                    foreach (var player in playerPerPlatform)
                    {
                        var sb = CreateRecentMatchesMessage(player);

                        await _bot.SendTextMessageAsync(message.Chat, $"Listing *{player.epicUserHandle}'s* recent matches on *{player.platformNameLong}*:{Environment.NewLine}{sb}", ParseMode.Markdown, replyToMessageId: message.MessageId);
                    }
            }
        }

        private Task GetHelp(string args, Message message)
            => _bot.SendTextMessageAsync(message.Chat, @"/stats - Return player status; You must specify epics nickname and platform(optional)

    Sample: /stats Ninja

/recentmatches - List the last 10 recents player matches; You must specify epics nickname and platform(optional)

    Sample: /recentmatches Ninja

/help - Show this help message", ParseMode.Markdown, replyToMessageId: message.MessageId);
        #endregion

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

        private async Task<FortNitePlayer[]> GetPlayerFromArgs(Message message, string[] argsParts)
        {
            if (argsParts.Length == 1)
            {
                var nick = argsParts[0];

                var playersPerPlatform = await Task.WhenAll(
                    _client.GetFortnitePlayerStatus(FortNitePlatform.psn, nick),
                    _client.GetFortnitePlayerStatus(FortNitePlatform.pc, nick),
                    _client.GetFortnitePlayerStatus(FortNitePlatform.xbl, nick)).ConfigureAwait(false);

                return playersPerPlatform.Where(p => !string.IsNullOrEmpty(p.accountId)).ToArray();
            }
            else if (argsParts.Length == 2)
            {
                var nick = argsParts[0];
                var platform = argsParts[1];

                if (Enum.TryParse<FortNitePlatform>(platform, true, out var result))
                    return new[] { await _client.GetFortnitePlayerStatus(result, nick) };
            }
            return null;
        }

        private async Task AnswerWithPlayerStats(Message message, string nick, FortNitePlayer player)
        {
            var sb = new StringBuilder();
            foreach (var item in player.lifeTimeStats.Skip(7))
                sb.AppendLine($"{item.key}: {item.value}");

            await _bot.SendTextMessageAsync(message.Chat, $"The *{nick}'s* stats on *{player.platformNameLong}* is:{Environment.NewLine}{sb}", ParseMode.Markdown, replyToMessageId: message.MessageId);
        }
    }
}
