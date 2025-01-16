using Application.Interfaces.Commands;

namespace Application.Authentication.Commands
{
    public sealed record LoginStaffCommand(string Email, string Password) : ICommand<string>;
}