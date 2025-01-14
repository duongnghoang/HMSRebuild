using Application.Interfaces.Queries;
using Domain.Abstractions.Repositories;

namespace Application.Authentication.Queries
{
    public record GetLoginStaffQueryResult(string Token);

    public class GetLoginStaffQueryHandler : IQueryHandler<GetLoginStaffQuery, GetLoginStaffQueryResult>
    {
        private readonly IStaffRepository _staffRepository;

        public async Task<GetLoginStaffQueryResult> Handle(GetLoginStaffQuery request,
            CancellationToken cancellationToken)
        {
            var staff = await _staffRepository.GetStaffByEmailAndPassword(request.Email, request.Password);
        }
    }
}