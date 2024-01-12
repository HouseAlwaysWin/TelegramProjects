using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace TelegramBotAPIDemo.Controllers
{
	[Route("[controller]/[action]")]
	[ApiController]
	public class BotController : ControllerBase
	{

		[HttpPost]
		public async Task<IActionResult> HandleRequest([FromBody] Update update)
		{
			return Ok();
		}
	}
}
