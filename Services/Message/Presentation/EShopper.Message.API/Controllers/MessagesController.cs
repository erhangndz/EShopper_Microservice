using EShopper.Message.Application.Features.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Message.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj Oluşturuldu");
        }
    }
}
