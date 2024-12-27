using MediatR;

namespace Application.Interfaces.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
