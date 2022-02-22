﻿using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramApiForProvider.Service
{
    public interface ITelegramBotService
    {
        void SendMessage(long chatId, string text);
        Task<Message> SendMessage(long chatId, string text, IReplyMarkup replyMarkup);
        void EditMessage(long chatId, int messageId);
    }
}
