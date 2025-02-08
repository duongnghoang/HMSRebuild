using Domain.Shared;

namespace Domain.Entities.Users
{
    public static class AuthenticationErrors
    {
        public static readonly Error LoginValidation = new Error("AUTH-001", "Wrong email or password");
    }
}