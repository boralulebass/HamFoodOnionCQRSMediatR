using AutoMapper;
using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Interfaces;
using HamFood.Infrastructure.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Infrastructure.Persistance.Repositories
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly HamFoodContext _context;
        private readonly IMapper _mapper;

        public EfCategoryRepository(HamFoodContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ResultCategoryDto>> GetCategoryList()
        {
            var values = await _context.Categories.Include(x => x.Menus).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(values);

        }
    }
}
