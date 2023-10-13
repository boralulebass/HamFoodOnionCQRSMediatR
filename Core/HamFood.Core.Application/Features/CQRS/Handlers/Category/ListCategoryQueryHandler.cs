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
    public class ListCategoryQueryHandler : IRequestHandler<ListCategoryQueryRequest, List<ResultCategoryDto>>
    {
        private readonly IRepository<HamFood.Core.Domain.Entities.Category> _repository;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public ListCategoryQueryHandler(IRepository<HamFood.Core.Domain.Entities.Category> repository, IMapper mapper, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<ResultCategoryDto>> Handle(ListCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetCategoryList();
            
            //var values = await _repository.GetAllAsync();
            //return _mapper.Map<List<ResultCategoryDto>>(values);            
        }
    }
}
