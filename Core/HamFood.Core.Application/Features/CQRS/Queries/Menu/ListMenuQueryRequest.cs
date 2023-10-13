using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Queries
{
	public class ListMenuQueryRequest :IRequest<List<ResultMenuDto>>
	{
		
	}
}
