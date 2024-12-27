﻿using MediatR;

namespace Application.Interfaces.Queries
{
    public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : IQuery<TResponse>
    {
    }
}
