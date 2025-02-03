using Application.Interfaces;

namespace Application.Authentication.Login
{
    public sealed record LoginStaffCommand(string Email, string Password) : ICommand<string>;
}