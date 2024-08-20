using EShopper.Message.Application.Interfaces;
using EShopper.Message.Domain.Entities;
using EShopper.Message.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Persistence.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly MessageContext _context;

        public MessageService(MessageContext context)
        {
            _context = context;
        }

        public async Task CreateMessage(UserMessage userMessage)
        {
            await _context.AddAsync(userMessage);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMessage(int id)
        {
            var value = await GetMessageById(id);
            _context.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserMessage>> GetAllMessages()
        {
            return await _context.UserMessages.ToListAsync();
        }

        public async Task<UserMessage> GetMessageById(int id)
        {
            return await _context.UserMessages.FindAsync(id);
        }

        public async Task UpdateMessage(UserMessage userMessage)
        {
            _context.Update(userMessage);
            await _context.SaveChangesAsync();
        }
    }
}
