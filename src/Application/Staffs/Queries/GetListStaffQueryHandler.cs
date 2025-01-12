using Application.Interfaces.Queries;
using Domain.Abstractions.Repositories;

namespace Application.Staffs.Queries
{
    public class GetListStaffQueryHandler : IQueryHandler<GetListStaffQuery, GetListStaffQueryResult>
    {
        private readonly IStaffRepository _staffRepository;

        public GetListStaffQueryHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public Task<GetListStaffQueryResult> Handle(GetListStaffQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetListStaffQueryResult
    {
    }
}