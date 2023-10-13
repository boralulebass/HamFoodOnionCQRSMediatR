using AutoMapper;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Application.Features.CQRS.Queries;
using HamFood.Core.Application.Interfaces;
using HamFood.Core.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Handlers
{
	public class ListMenuQueryHandler : IRequestHandler<ListMenuQueryRequest, List<ResultMenuDto>>
	{
		private readonly IRepository<Menu> _repository;
		private readonly IMapper _mapper;
		public ListMenuQueryHandler(IRepository<Menu> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<ResultMenuDto>> Handle(ListMenuQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllIncluding(Menu => Menu.Category).ToListAsync();
			return _mapper.Map<List<ResultMenuDto>>(values);
		}
	}
}
