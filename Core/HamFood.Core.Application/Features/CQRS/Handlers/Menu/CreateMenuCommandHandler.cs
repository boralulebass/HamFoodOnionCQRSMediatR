using AutoMapper;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Application.Features.CQRS.Commands.Menu;
using HamFood.Core.Application.Interfaces;
using HamFood.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Handlers
{
	public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommandRequest, CreateMenuDto>
	{
		private readonly IRepository<Menu> _repository;
		private readonly IMapper _mapper;

		public CreateMenuCommandHandler(IRepository<Menu> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<CreateMenuDto> Handle(CreateMenuCommandRequest request, CancellationToken cancellationToken)
		{
			var value = new Menu
			{
				CategoryId = request.CategoryId,
				MenuName = request.MenuName,
				MenuDesc = request.MenuDesc,
				MenuPrice = request.MenuPrice
			};
			await _repository.CreateAsync(value);
			var result = _mapper.Map<CreateMenuDto>(value);
			return result;
		}
	}
}
