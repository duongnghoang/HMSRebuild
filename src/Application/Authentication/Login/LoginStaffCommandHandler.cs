using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Domain.Shared;
using Domain.Utilities;

namespace Application.Authentication.Login
{
    public sealed class LoginStaffCommandHandler : ICommandHandler<LoginStaffCommand>
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IJwtService _jwtService;

        public LoginStaffCommandHandler(IStaffRepository staffRepository, IJwtService jwtService)
        {
            _staffRepository = staffRepository;
            _jwtService = jwtService;
        }

        public async Task<Result> Handle(LoginStaffCommand request,
            CancellationToken cancellationToken)
        {
            var staff = await _staffRepository.LoginAsync(request.Email, request.Password);
            if (staff == null ||
                !PasswordHasher.VerifyPassword(request.Password, staff.PasswordHash!, staff.PasswordSalt!))
            {
                return Result.Failure(AuthenticationErrors.LoginValidation);
            }

            string token = await _jwtService.GenerateTokenAsync(staff);
            return Result.Success(token);
        }
    }
}