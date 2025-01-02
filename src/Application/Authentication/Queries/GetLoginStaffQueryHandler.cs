using Application.Interfaces.Queries;

namespace Application.Authentication.Queries
{
    public record GetLoginStaffQueryResult();
    public class GetLoginStaffQueryHandler : IQueryHandler<GetLoginStaffQuery, GetLoginStaffQueryResult>    
    {
        public Task<GetLoginStaffQueryResult> Handle(GetLoginStaffQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}