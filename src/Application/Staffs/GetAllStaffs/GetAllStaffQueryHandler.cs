using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Shared;

namespace Application.Staffs.GetAllStaffs
{
    public sealed class GetAllStaffQueryHandler : IQueryHandler<GetAllStaffQuery, PaginatedList<GetAllStaffQueryResult>>
    {
        private readonly IStaffRepository _staffRepository;

        public GetAllStaffQueryHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public Task<Result<PaginatedList<GetAllStaffQueryResult>>> Handle(GetAllStaffQuery request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetAllStaffQueryResult
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}