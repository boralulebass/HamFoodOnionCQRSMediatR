using HamFood.Core.Application.Dtos.MenuDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Commands.Menu
{
    public class CreateMenuCommandRequest : IRequest<CreateMenuDto>
    {
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public decimal MenuPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
