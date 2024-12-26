using MediatR;

namespace HMS.Core.Application.Interfaces.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
