using FortNiteStatus.Core;
using FortNiteStatus.Core.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatus.TelegramBot.Commands
{
    internal abstract class BaseCommand : IFortniteCommand
    {
        protected readonly IFortNiteTrackerApi _client;

        protected BaseCommand(IFortNiteTrackerApi client) 
            => _client = client;

        public abstract Task<string> Handle(string args, Message message);

        protected async Task<FortNitePlayer[]> GetPlayerFromArgs(string[] argsParts)
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
    }
}
