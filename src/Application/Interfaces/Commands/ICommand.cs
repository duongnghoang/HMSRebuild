using MediatR;

namespace Application.Interfaces.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}