using AutoMapper;
using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Features.CQRS.Commands.Category;
using HamFood.Core.Application.Interfaces;
using MediatR;
using HamFood.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Handlers.Category
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryDto>
    {
        private readonly IRepository<HamFood.Core.Domain.Entities.Category> _repository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IRepository<HamFood.Core.Domain.Entities.Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateCategoryDto> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var value = new HamFood.Core.Domain.Entities.Category
            {
                CategoryName = request.CategoryName
            };
            await _repository.CreateAsync(value);
            var result = _mapper.Map<CreateCategoryDto>(value);
            return result;
        }
    }
}
