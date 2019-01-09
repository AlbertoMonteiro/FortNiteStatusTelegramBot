using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatusTelegramBot.Commands
{
    public interface IFortniteCommand
    {
        Task<string> Handle(string args, Message message);
    }
}
