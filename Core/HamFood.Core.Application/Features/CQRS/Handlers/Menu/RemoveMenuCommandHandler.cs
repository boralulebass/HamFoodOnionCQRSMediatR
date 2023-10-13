using HamFood.Core.Application.Features.CQRS.Commands.Menu;
using HamFood.Core.Application.Interfaces;
using HamFood.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Features.CQRS.Handlers
{
	public class RemoveMenuCommandHandler : IRequestHandler<RemoveMenuCommandRequest>
	{
		private readonly IRepository<Menu> _repository;

		public RemoveMenuCommandHandler(IRepository<Menu> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveMenuCommandRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			if (value == null)
			{
				return;
			}
			else
			{
				await _repository.DeleteAsync(value);
			}
		}
	}
}
