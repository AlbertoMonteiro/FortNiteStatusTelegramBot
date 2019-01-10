using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FortNiteStatus.TelegramBot
{
    public sealed class TelegramBotManualEngine
    {
        private readonly TelegramBotClient _bot;
        private readonly CommandHandler _commandHandler;

        public TelegramBotManualEngine(string telegramToken, string trnApiKey)
        {
            _bot = new TelegramBotClient(telegramToken);
            _commandHandler = new CommandHandler(_bot, trnApiKey);
        }

        public async Task ReadUpdates()
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

        private Task HandleMessage(Message message)
        {
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                return _commandHandler.HandleCommand(message);

            return Task.CompletedTask;
        }
    }
}
