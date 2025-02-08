using Domain.Shared;

namespace Domain.Entities.RoomTypeFees
{
    public static class FeePolicyErrors
    {
        public static readonly Error FeePolicyNameExist =
            new Error("FPL-001", "Fee policy name already exist");
    }
}