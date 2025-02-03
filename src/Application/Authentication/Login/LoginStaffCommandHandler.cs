using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Entities.Users;

namespace Application.Authentication.Login
{
    public sealed class LoginStaffCommandHandler : ICommandHandler<LoginStaffCommand, string>
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
            var staff = await _staffRepository.LoginAsync(request.Email, request.Password);
            if (staff == null)
            {
                return new string("No staff");
            }

            return await _jwtService.GenerateTokenAsync(staff);
        }
    }
}