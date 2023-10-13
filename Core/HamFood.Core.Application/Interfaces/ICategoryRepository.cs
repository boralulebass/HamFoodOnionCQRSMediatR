using HamFood.Core.Application.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetCategoryList();
    }
}
