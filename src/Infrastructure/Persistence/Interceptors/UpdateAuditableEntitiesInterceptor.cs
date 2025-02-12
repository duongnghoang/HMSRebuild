﻿using Domain.Abstractions.BaseObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Persistence.Interceptors
{
    public sealed class UpdateAuditableEntitiesInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData,
            InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            DbContext? dbContext = eventData.Context;
            if (dbContext is null)
            {
                return base.SavingChangesAsync(eventData, result, cancellationToken);
            }

            IEnumerable<EntityEntry<IAuditableEntity>> entries = dbContext.ChangeTracker.Entries<IAuditableEntity>();
            foreach (EntityEntry<IAuditableEntity> entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property(entity => entity.CreatedAt).CurrentValue = DateTime.UtcNow;
                }
                else if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property(entity => entity.ModifiedAt).CurrentValue = DateTime.UtcNow;
                }
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}