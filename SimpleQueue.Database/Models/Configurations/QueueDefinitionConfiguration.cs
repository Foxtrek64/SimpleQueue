//
//  QueueDefinitionConfiguration.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpleQueue.Database.Models.Configurations
{
    /// <summary>
    /// Configures the <see cref="QueueDefinition"/> type.
    /// </summary>
    public sealed class QueueDefinitionConfiguration : IEntityTypeConfiguration<QueueDefinition>
    {
        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<QueueDefinition> builder)
        {
            // Wire up the queue items collection
            builder.HasMany(x => x.QueueItems).WithOne(x => x.QueueDefinition);
        }
    }
}
