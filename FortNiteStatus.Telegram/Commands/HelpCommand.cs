using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatus.TelegramBot.Commands
{
    internal sealed class HelpCommand : IFortniteCommand
    {
        public Task<string> Handle(string args, Message message) 
            => Task.FromResult(@"/stats - Return player status; You must specify epics nickname and platform(optional)

    Sample: /stats Ninja

/recentmatches - List the last 10 recents player matches; You must specify epics nickname and platform(optional)

    Sample: /recentmatches Ninja

/help - Show this help message");
    }
}
