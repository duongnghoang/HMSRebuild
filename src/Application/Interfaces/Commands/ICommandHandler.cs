using MediatR;

namespace Application.Interfaces.Commands
{
    public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : ICommand<TResponse>
    {
    }
}
