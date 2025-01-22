using Application.Interfaces;
using Domain.Abstractions.Repositories;

namespace Application.Authentication.Commands
{
    public class LoginStaffCommandHandler : ICommandHandler<LoginStaffCommand, string>
    {
        private readonly IStaffRepository _staffRepository;

        public LoginStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<string> Handle(LoginStaffCommand request,
            CancellationToken cancellationToken)
        {
            var staff = await _staffRepository.GetStaffByEmailAndPassword(request.Email, request.Password);
            if (staff == null)
            {
                return new string("No staff");
            }

            return new string(staff.Name);
        }
    }
}