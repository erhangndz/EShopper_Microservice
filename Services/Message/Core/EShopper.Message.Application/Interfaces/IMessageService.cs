using EShopper.Message.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Interfaces
{
    public interface IMessageService
    {
        Task<List<UserMessage>> GetAllMessages();

        Task<UserMessage> GetMessageById(int id);

        Task DeleteMessage(int id);

        Task UpdateMessage(UserMessage userMessage);

        Task CreateMessage(UserMessage userMessage);

    }
}
