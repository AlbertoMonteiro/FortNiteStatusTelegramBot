using FortNiteStatus.Core;
using FortNiteStatus.TelegramBot.Commands;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace FortNiteStatus.TelegramBot
{
    public class CommandHandler
    {
        private readonly Dictionary<string, IFortniteCommand> _commands;
        private readonly IFortNiteTrackerApi _client;
        private readonly TelegramBotClient _bot;

        public CommandHandler(string telegramToken, string trnApiKey)
            :this(new TelegramBotClient(telegramToken), trnApiKey)
        { }

        public CommandHandler(TelegramBotClient bot, string trnApiKey)
        {
            var ftCommandType = typeof(IFortniteCommand);
            var commandTypes = typeof(CommandHandler).Assembly.GetTypes()
                .Where(t => ftCommandType.IsAssignableFrom(t))
                .Where(t => t.IsClass && !t.IsAbstract)
                .ToArray();

            _bot = bot;
            _client = RestService.For<IFortNiteTrackerApi>(new HttpClient(new AuthenticatedHttpClientHandler(trnApiKey)) { BaseAddress = new Uri("https://api.fortnitetracker.com") });
            _commands = commandTypes.ToDictionary(t => t.Name.Replace("Command", "").ToLower(), t => CreateCommandInstance(t));
        }

        private IFortniteCommand CreateCommandInstance(Type type)
        {
            var ftBaseCommandType = typeof(BaseCommand);
            if (ftBaseCommandType.IsAssignableFrom(type))
                return (IFortniteCommand)Activator.CreateInstance(type, new object[] { _client });

            return (IFortniteCommand)Activator.CreateInstance(type);
        }

        public async Task HandleCommand(Message message)
        {
            var match = Regex.Match(message.Text, @"/(?<command>\w+)(@\w+)?(\s(?<args>.*))?");
            if (!match.Success)
            {
                await _bot.SendTextMessageAsync(message.Chat, $"The command is invalid");
            }
            else
            {
                var command = match.Groups["command"].Value;
                var args = match.Groups["args"].Value;

                var msg = !_commands.ContainsKey(command = command.ToLower())
                    ? "Unknow command"
                    : await _commands[command].Handle(args, message);

                await _bot.SendTextMessageAsync(message.Chat, msg, ParseMode.Markdown, replyToMessageId: message.MessageId); 
            }
        }
    }
}