using HamFood.Core.Application.Dtos.CategoryDtos;
using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Commands.Category
{
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryDto>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
