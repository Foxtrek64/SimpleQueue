//
//  QueueDefinition.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

// Required keyword goes after public.
#pragma warning disable SA1206 // Declaration keywords should follow order

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Defines a queue.
    /// </summary>
    public sealed record class QueueDefinition
    {
        /// <summary>
        /// Gets the unique id associated with this queue.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets the name of the queue.
        /// </summary>
        /// <remarks>
        /// This field must be unique.
        /// </remarks>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public required string? Description { get; set; }

        /// <summary>
        /// Gets or sets the number of times this queue will automatically requeue failed items.
        /// </summary>
        public int MaxNumberOfRetries { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this queue will automatically requeue failed items.
        /// </summary>
        public bool AutomaticallyRetry { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this queue has been deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the Active Directory user id of the user who deleted the queue.
        /// </summary>
        public Guid? DeleterUserId { get; set; }

        /// <summary>
        /// Gets or sets the date and time at which the queue was deleted.
        /// </summary>
        public DateTimeOffset? DeletionTime { get; set; }

        /// <summary>
        /// Gets or sets the date at which this queue was last updated.
        /// </summary>
        public DateTimeOffset? LastModificationTime { get; set; }

        /// <summary>
        /// Gets or sets the Active Directory user id of the user who last updated the queue.
        /// </summary>
        public Guid? ModifierUserId { get; set; }

        /// <summary>
        /// Gets the date and time when this queue was created.
        /// </summary>
        public required DateTimeOffset CreationDate { get; init; }

        /// <summary>
        /// Gets the Active Directory user id of the user who created this queue.
        /// </summary>
        public required Guid CreatorUserId { get; init; }

        /// <summary>
        /// Gets a value indicating whether to treat the Reference field as unique.
        /// </summary>
        public bool EnforceUniqueReference { get; init; }

        /// <summary>
        /// Gets a list of the queue items belonging to this queue.
        /// </summary>
        public IReadOnlyList<QueueItem> QueueItems => _queueItems.AsReadOnly();

        /// <summary>
        /// Gets a list of the queue items associated with this queue.
        /// </summary>
        private List<QueueItem> _queueItems = new();
    }
}
