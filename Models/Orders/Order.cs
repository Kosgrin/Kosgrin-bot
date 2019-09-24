using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram_Bot.Models.Orders
{
    public abstract class Order
    {
        public abstract string Name { get; }

        public abstract Task Execute(Message message, TelegramBotClient client);

        public  bool Contains(string order)
        {
            return order.Contains(this.Name) && order.Contains(AppSetings.Name);
        }
    }
}
