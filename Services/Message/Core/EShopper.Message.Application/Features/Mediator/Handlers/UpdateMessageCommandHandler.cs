using EShopper.Message.Application.Features.Mediator.Commands;
using EShopper.Message.Application.Interfaces;
using EShopper.Message.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Features.Mediator.Handlers
{
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand>
    {
        private readonly IMessageService _messageService;

        public UpdateMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new UserMessage
            {
                Email = request.Email,
                MessageContent = request.MessageContent,
                NameSurname = request.NameSurname,
                Subject = request.Subject,
                UserMessageId = request.UserMessageId
            };

            await _messageService.UpdateMessage(message);
        }
    }
}
