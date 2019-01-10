using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;

namespace FortNiteStatus.Core
{
    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly string _trnApiKey;

        public AuthenticatedHttpClientHandler(string trnApiKey)
            => _trnApiKey = trnApiKey;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("TRN-Api-Key", _trnApiKey);

            return base.SendAsync(request, cancellationToken);
        }
    }
}
