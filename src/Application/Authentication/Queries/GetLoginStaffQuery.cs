using Application.Interfaces.Queries;

namespace Application.Authentication.Queries
{
    public class GetLoginStaffQuery : IQuery<GetLoginStaffQueryResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}