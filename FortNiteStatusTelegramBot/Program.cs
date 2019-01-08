using Microsoft.Extensions.Configuration;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FortNiteStatusTelegramBot
{
    class Program
    {
        private static TelegramBotClient _bot;
        private static CommandHandler _commandHandler;

        static Task Main(string[] args)
        {
            if (!System.IO.File.Exists("appSettings.json"))
            {
                Console.WriteLine("appSettings.json file was not found, please add one with TRN-Api-Key and TelegramToken values");
                return Task.CompletedTask;
            }

            var configs = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();

            var trnApiKey = configs.GetSection("TRN-Api-Key").Value;
            var telegramToken = configs.GetSection("TelegramToken").Value;

            _bot = new TelegramBotClient(telegramToken);
            _commandHandler = new CommandHandler(_bot, trnApiKey);

            Console.WriteLine("Reading updates");
            return ReadUpdates();
        }

        private static async Task ReadUpdates()
        {
            int offset = 0;

            while (true)
            {
                var updates = await _bot.GetUpdatesAsync(offset, 10);

                foreach (var update in updates)
                {
                    Console.WriteLine($"Handling message {update.Id}");
                    try
                    {
                        if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                            await HandleMessage(update.Message).ConfigureAwait(false);
                        else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.EditedMessage)
                            await HandleMessage(update.EditedMessage).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    offset = update.Id + 1;
                }
            }
        }

        private static Task HandleMessage(Message message)
        {
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                var match = Regex.Match(message.Text, @"/(?<command>\w+)(@\w+)?(\s(?<args>.*))?");
                if (!match.Success)
                    return _bot.SendTextMessageAsync(message.Chat, $"The command is invalid");

                var command = match.Groups["command"].Value;
                var args = match.Groups["args"].Value;

                return _commandHandler.HandleCommand(message, command, args);
            }
            return Task.CompletedTask;
        }
    }
}
