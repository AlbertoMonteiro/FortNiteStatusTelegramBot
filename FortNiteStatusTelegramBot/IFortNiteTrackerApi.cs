using Refit;
using System.Threading.Tasks;

namespace FortNiteStatusTelegramBot
{
    internal interface IFortNiteTrackerApi
    {
        [Get("/v1/profile/{platform}/{epicNickname}")]
        Task<FortNitePlayer> GetFortnitePlayerStatus(FortNitePlatform platform, string epicNickname);
    }
}
