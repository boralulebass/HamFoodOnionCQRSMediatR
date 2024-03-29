﻿using HamFood.Core.Application.Dtos.CategoryDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Commands.Category
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryDto>
    {
        public string CategoryName { get; set; }
    }

}
