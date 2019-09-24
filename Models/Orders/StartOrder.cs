using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram_Bot.Models.Orders
{
	public class StartOrder : Order
	{
		public override string Name => "/start";

		

		public override async Task Execute(Message message, TelegramBotClient client)
		{
			var chatId = message.Chat.Id;

			await client.SendTextMessageAsync(chatId, "Hello I'm Kosgrin_bot", parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
		}
	}
}
