using EShopper.Message.Application.Features.Mediator.Commands;
using EShopper.Message.Application.Features.Mediator.Queries;
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
            return Ok("Mesaj başarıyla oluşturuldu");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMessages()
        {
            var values = await _mediator.Send(new GetMessageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var value = await _mediator.Send(new GetMessageByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _mediator.Send(new RemoveMessageCommand(id));
            return Ok("Mesaj başarıyla silindi");
        }
    }
}
