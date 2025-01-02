using Application.Interfaces.Commands;
using Domain.Abstractions.Repositories;

namespace Application.Staffs.Commands
{
    public record CreateStaffCommandResult();

    internal sealed class CreateStaffCommandHandler : ICommandHandler<CreateStaffCommand, CreateStaffCommandResult>
    {
        private readonly IStaffRepository _staffRepository;

        private CreateStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public Task<CreateStaffCommandResult> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}