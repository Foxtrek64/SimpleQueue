//
//  QueueItemConfiguration.cs
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
    /// Configures the <see cref="QueueItemDefinition"/> type.
    /// </summary>
    public sealed class QueueItemConfiguration : IEntityTypeConfiguration<QueueItemDefinition>
    {
        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<QueueItemDefinition> builder)
        {
            builder.Ignore(x => x.QueueDataWrapper);
        }
    }
}
