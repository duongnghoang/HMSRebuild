using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Users
{
    public class RoleMenu
    {
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }

    }
}
