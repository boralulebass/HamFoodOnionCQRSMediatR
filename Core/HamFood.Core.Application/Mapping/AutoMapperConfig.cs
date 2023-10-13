using AutoMapper;
using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamMenu.Core.Application.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultCategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<ResultCategoryNoMenuDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, ResultCategoryDto>().ReverseMap();

            CreateMap<ResultMenuDto, Menu>().ReverseMap();
            CreateMap<CreateMenuDto, Menu>().ReverseMap();
            CreateMap<UpdateMenuDto, Menu>().ReverseMap();
            CreateMap<ResultMenuNoCatDto, Menu>().ReverseMap();
        }
    }
}
