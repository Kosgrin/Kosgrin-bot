using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram_Bot.Models.Orders
{
    public class TestOrder : Order
    {
        public override string Name => "/hello";

       

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO:  bot_logic

            await client.SendTextMessageAsync(chatId, "Hello I'm Kosgrin_bot",replyToMessageId: messageId);
        }
    }
}
