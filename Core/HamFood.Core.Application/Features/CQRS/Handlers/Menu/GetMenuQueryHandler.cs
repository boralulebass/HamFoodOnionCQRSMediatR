using AutoMapper;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Application.Features.CQRS.Queries;
using HamFood.Core.Application.Interfaces;
using HamFood.Core.Domain.Entities;

using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Handlers
{
	public class GetMenuQueryHandler : IRequestHandler<GetMenuQueryRequest, ResultMenuDto>
	{
		private readonly IRepository<Menu> _repository;
		private readonly IMapper _mapper;

		public GetMenuQueryHandler(IRepository<Menu> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<ResultMenuDto> Handle(GetMenuQueryRequest request, CancellationToken cancellationToken)
		{

			var value = await _repository.GetByIdAsync(request.Id);
			return _mapper.Map<ResultMenuDto>(value);
		}
	}
}
