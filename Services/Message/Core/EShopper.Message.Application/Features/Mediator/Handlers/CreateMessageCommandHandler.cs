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
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand>
    {
        private readonly IMessageService _messageService;

        public CreateMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            await _messageService.CreateMessage(new UserMessage
            {
                Email = request.Email,
                MessageContent = request.MessageContent,
                NameSurname = request.NameSurname,
                Subject = request.Subject,

            });
        }
    }
}
