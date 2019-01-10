using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FortNiteStatus.TelegramBot.Commands
{
    public interface IFortniteCommand
    {
        Task<string> Handle(string args, Message message);
    }
}
