using AutoMapper;
using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Features.CQRS.Queries.Category;
using HamFood.Core.Application.Interfaces;
using HamFood.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Handlers.Category
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, ResultCategoryDto>
    {
        private readonly IRepository<HamFood.Core.Domain.Entities.Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(IRepository<HamFood.Core.Domain.Entities.Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultCategoryDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultCategoryDto>(value);
        }
    }
}
