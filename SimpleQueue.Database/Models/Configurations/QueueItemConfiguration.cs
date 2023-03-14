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
    /// Configures the <see cref="QueueItem"/> type.
    /// </summary>
    public sealed class QueueItemConfiguration : IEntityTypeConfiguration<QueueItem>
    {
        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<QueueItem> builder)
        {
            builder.Ignore(x => x.JsonValueWrapper);
        }
    }
}
