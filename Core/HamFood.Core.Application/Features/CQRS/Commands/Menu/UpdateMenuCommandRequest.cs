using HamFood.Core.Application.Dtos.MenuDtos;
using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Commands.Menu
{
    public class UpdateMenuCommandRequest : IRequest<UpdateMenuDto>
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public decimal MenuPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
