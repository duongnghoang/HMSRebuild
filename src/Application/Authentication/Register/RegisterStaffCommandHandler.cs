using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Domain.Shared;
using Domain.Utilities;
using Mapster;

namespace Application.Authentication.Register
{
    public class RegisterStaffCommandHandler : ICommandHandler<RegisterStaffCommand, Guid>
    {
        private readonly IStaffRepository _staffRepository;

        public RegisterStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<Result<Guid>> Handle(RegisterStaffCommand request, CancellationToken cancellationToken)
        {
            // Hash the password
            var (hash, salt) = PasswordHasher.HashPassword(request.Password!);

            // Create the staff entity
            var staff = request.Adapt<Staff>();
            staff.PasswordHash = hash;
            staff.PasswordSalt = salt;

            // Save to database
            await _staffRepository.AddAsync(staff);

            return Result.Success(staff.Id);
        }
    }
}