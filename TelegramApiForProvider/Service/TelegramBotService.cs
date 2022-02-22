﻿using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramApiForProvider.Service
{
    public class TelegramBotService : ITelegramBotService
    {
       private readonly TelegramBotClient _client;

        public TelegramBotService(string token, string callBackUrl)
        {
            _client = new TelegramBotClient(token);
            _client.SetWebhookAsync(callBackUrl);
        }

        public void EditMessage(long chatId, int messageId)
        {
            _client.EditMessageReplyMarkupAsync(chatId, messageId);
        }

        public void SendMessage(long chatId, string text)
        {
            _client.SendTextMessageAsync(chatId, text);
        }

        public Task<Message> SendMessage(long chatId, string text, IReplyMarkup replyMarkup)
        {
            return _client.SendTextMessageAsync(chatId, text, replyMarkup: replyMarkup);
        }
    }
}
