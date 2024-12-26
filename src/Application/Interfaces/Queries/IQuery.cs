using MediatR;

namespace HMS.Core.Application.Interfaces.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
