using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using Telegram_Bot.Models;

namespace Telegram_Bot.Controllers
{
	[Route(@"api/message/update")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public string Get()
		{
			return "Method Get is unavaiable";
		}

		// POST api/values
		[HttpPost]
		public async Task<OkResult> Update([FromBody]Update update)
		{
			if (update == null) return Ok();

			var orders = Bot.Orders;
			var message = update.Message;
			var botClient = await Bot.GetBotClientAsync();

			foreach (var order in orders)
			{
				if (order.Contains(message.Text))
				{
					await order.Execute(message, botClient);
					break;
				}
			}
			return Ok();
		}
	}
}
