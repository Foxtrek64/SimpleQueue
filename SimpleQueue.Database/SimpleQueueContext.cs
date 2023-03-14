//
//  SimpleQueueContext.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SimpleQueue.Database.Models;

namespace SimpleQueue.Database
{
    /// <summary>
    /// Provides a DbContext for this service.
    /// </summary>
    public sealed class SimpleQueueContext : DbContext
    {
        /// <summary>
        /// Gets a set of queues.
        /// </summary>
        public DbSet<QueueDefinition> Queues => Set<QueueDefinition>();

        /// <summary>
        /// Gets a set of queue items.
        /// </summary>
        public DbSet<QueueItemDefinition> QueueItems => Set<QueueItemDefinition>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQueueContext"/> class.
        /// </summary>
        /// <param name="options">Options to configure this context.</param>
        public SimpleQueueContext(DbContextOptions<SimpleQueueContext> options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
