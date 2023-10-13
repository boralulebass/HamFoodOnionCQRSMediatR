using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Domain.Entities;
using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Queries
{
	public class GetMenuQueryRequest : IRequest<ResultMenuDto>
	{
		public GetMenuQueryRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
