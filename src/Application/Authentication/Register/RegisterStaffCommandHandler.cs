using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Domain.Utilities;

namespace Application.Authentication.Register
{
    public class RegisterStaffCommandHandler : ICommandHandler<RegisterStaffCommand, Guid>
    {
        private readonly IStaffRepository _staffRepository;

        public RegisterStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<Guid> Handle(RegisterStaffCommand request, CancellationToken cancellationToken)
        {
            // Hash the password
            var (hash, salt) = PasswordHasher.HashPassword(request.Password);

            // Create the staff entity
            var staff = new Staff
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                RoleId = request.RoleId,
                PasswordHash = hash,
                PasswordSalt = salt,
                IsActive = true
            };

            // Save to database
            await _staffRepository.AddAsync(staff);

            return staff.Id;
        }
    }
}