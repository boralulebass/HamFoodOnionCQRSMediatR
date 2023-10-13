using HamFood.Core.Application.Dtos.MenuDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Dtos.CategoryDtos
{
    public class ResultCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ResultMenuNoCatDto>? Menus { get; set; }
    }
}
