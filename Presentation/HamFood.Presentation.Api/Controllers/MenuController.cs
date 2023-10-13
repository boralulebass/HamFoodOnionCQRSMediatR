using HamFood.Core.Application.Features.CQRS.Commands.Menu;
using HamFood.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamMenu.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<IActionResult> MenuList()
        {
            var values = await _mediator.Send(new ListMenuQueryRequest());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMenu(CreateMenuCommandRequest createMenuCommandRequest)
        {
            await _mediator.Send(createMenuCommandRequest);
            return Ok("Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuById(int id)
        {
            var value = await _mediator.Send(new GetMenuQueryRequest(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            await _mediator.Send(new RemoveMenuCommandRequest(id));
            return Ok("Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMenu(UpdateMenuCommandRequest updateMenuCommandRequest)
        {
            await _mediator.Send(updateMenuCommandRequest);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
