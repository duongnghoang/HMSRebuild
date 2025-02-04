using Domain.Shared;

namespace Domain.Entities.Users
{
    public static class AuthenticationErrors
    {
        public static readonly Error LoginValidation = new("MSG-0001", "Invalid email or password");
    }
}