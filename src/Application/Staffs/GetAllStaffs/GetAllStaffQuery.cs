using Application.Interfaces;
using Domain.Shared;

namespace Application.Staffs.GetAllStaffs
{
    public class GetAllStaffQuery : IQuery<PaginatedList<GetAllStaffQueryResult>>
    {
    }
}