using FortNiteStatus.Core.Models;
using Refit;
using System.Threading.Tasks;

namespace FortNiteStatus.Core
{
    public interface IFortNiteTrackerApi
    {
        [Get("/v1/profile/{platform}/{epicNickname}")]
        Task<FortNitePlayer> GetFortnitePlayerStatus(FortNitePlatform platform, string epicNickname);
    }
}
