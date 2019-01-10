using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using Telegram.Bot;
using System.Threading.Tasks;
using FortNiteStatus.TelegramBot;

namespace TelegramBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        private readonly TelegramBotClient _bot;
        private readonly CommandHandler _commandHandler;

        public WebHookController(TelegramBotClient bot, CommandHandler commandHandler)
        {
            _bot = bot;
            _commandHandler = commandHandler;
        }

        [HttpPost]
        public async Task Post([FromBody] Telegram.Bot.Types.Update update)
        {
            await _commandHandler.HandleCommand(update.Message);
        }

        [HttpGet]
        public async Task Get()
        {            
            var url = Request.GetEncodedUrl();

            await _bot.SetWebhookAsync(url).ConfigureAwait(false);
        }

        [HttpGet]
        [Route("healthcheck")]
        public ActionResult HealthCheck() 
            => Content("Running");
    }
}
