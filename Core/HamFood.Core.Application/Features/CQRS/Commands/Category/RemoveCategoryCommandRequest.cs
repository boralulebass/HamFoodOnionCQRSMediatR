﻿using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Commands.Category
{
    public class RemoveCategoryCommandRequest : IRequest

    {
        public RemoveCategoryCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

}
