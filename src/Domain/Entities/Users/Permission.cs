﻿using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class Permission : BaseEntity
    {
        // Properties
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public Guid ParentPermissionId { get; private set; }
        public virtual Permission? ParentPermission { get; private set; }
        public virtual RolePermission? RolePermission { get; private set; }
        public virtual ICollection<Permission>? ChildPermissions { get; private set; }
        public virtual ICollection<RolePermission>? RolePermissions { get; private set; }
    }
}