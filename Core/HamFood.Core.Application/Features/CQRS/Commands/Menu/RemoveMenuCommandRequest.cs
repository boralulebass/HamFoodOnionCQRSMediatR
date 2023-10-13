using MediatR;

namespace HamFood.Core.Application.Features.CQRS.Commands.Menu
{
    public class RemoveMenuCommandRequest : IRequest
    {
        public RemoveMenuCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
