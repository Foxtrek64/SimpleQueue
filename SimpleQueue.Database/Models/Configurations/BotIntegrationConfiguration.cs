//
//  BotIntegrationConfiguration.cs
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
    /// Configures a <see cref="BotIntegrationDefinition"/>.
    /// </summary>
    public sealed class BotIntegrationConfiguration : IEntityTypeConfiguration<BotIntegrationDefinition>
    {
        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<BotIntegrationDefinition> builder)
        {
            builder.HasOne(x => x.ServerConnection).WithMany();

            builder.Ignore(x => x.InputParametersDocument);
        }
    }
}
