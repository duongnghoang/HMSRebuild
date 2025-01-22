using Application.Interfaces;
using Domain.Abstractions.Repositories;

namespace Application.Authentication.Commands
{
    public class LoginStaffCommandHandler : ICommandHandler<LoginStaffCommand, string>
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IJwtService _jwtService;

        public LoginStaffCommandHandler(IStaffRepository staffRepository, IJwtService jwtService)
        {
            _staffRepository = staffRepository;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(LoginStaffCommand request,
            CancellationToken cancellationToken)
        {
            var staff = await _staffRepository.GetStaffByEmailAndPassword(request.Email, request.Password);
            if (staff == null)
            {
                return new string("No staff");
            }

            return _jwtService.GenerateToken(staff);
        }
    }
}