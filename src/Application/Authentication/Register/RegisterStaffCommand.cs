using Application.Interfaces;

namespace Application.Authentication.Register
{
    public class RegisterStaffCommand : ICommand<Guid>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public Guid? RoleId { get; set; }
    }
}