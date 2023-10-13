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
	public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommandRequest, UpdateMenuDto>
	{
		private readonly IRepository<Menu> _repository;
		private readonly IMapper _mapper;

		public UpdateMenuCommandHandler(IRepository<Menu> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<UpdateMenuDto> Handle(UpdateMenuCommandRequest request, CancellationToken cancellationToken)
		{
			var value = new Menu
			{
				MenuDesc = request.MenuDesc,
				MenuId = request.MenuId,
				CategoryId = request.CategoryId,
				MenuName = request.MenuName,
				MenuPrice=request.MenuPrice
			};
			await _repository.UpdateAsync(value);
			var result = _mapper.Map<UpdateMenuDto>(value);
			return result;

		}
	}
}
