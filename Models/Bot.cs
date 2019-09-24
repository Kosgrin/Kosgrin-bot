using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram_Bot.Models.Orders;

namespace Telegram_Bot.Models
{
	public class Bot
	{
		private static TelegramBotClient botClient;
		private static List<Order> ordersList;

		public static IReadOnlyList<Order> Orders { get => ordersList.AsReadOnly(); }

		public static async Task<TelegramBotClient> GetBotClientAsync()
		{
			if(botClient != null)
			{
				return botClient;
			}

			ordersList = new List<Order>();
			ordersList.Add(new StartOrder());
            ordersList.Add(new TestOrder());

			botClient = new TelegramBotClient(AppSetings.Key);

			string hook = string.Format(AppSetings.URL, "api/message/update");


            await botClient.SetWebhookAsync("https://e47519fc.ngrok.io:443/api/message/update");


            return botClient;
		}

	}
}
