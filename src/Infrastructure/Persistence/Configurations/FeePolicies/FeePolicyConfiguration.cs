﻿using Domain.Entities.RoomTypeFees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.FeePolicies
{
    internal sealed class FeePolicyConfiguration : IEntityTypeConfiguration<FeePolicy>
    {
        public void Configure(EntityTypeBuilder<FeePolicy> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}