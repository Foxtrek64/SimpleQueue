//
//  QueueItem.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System.Text.Json;

// Required keyword goes after public.
#pragma warning disable SA1206 // Declaration keywords should follow order

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Represents a queue item.
    /// </summary>
    public sealed record class QueueItem
    {
        /// <summary>
        /// Gets the unique id of this queue item.
        /// </summary>
        public required int Id { get; init; }

        /// <summary>
        /// Gets the priority of this queue item.
        /// </summary>
        /// <remarks>
        /// A higher priority means the queue item will be worked sooner than others.
        /// </remarks>
        public required Priority Priority { get; init; }

        /// <summary>
        /// Gets the queue this item belongs to.
        /// </summary>
        public required QueueDefinition QueueDefinition { get; init; }

        /// <summary>
        /// Gets or sets the status of this queue item.
        /// </summary>
        public Status Status { get; set; } = Status.New;

        /// <summary>
        /// Gets or sets the current review status of this queue item.
        /// </summary>
        public ReviewStatus ReviewStatus { get; set; } = ReviewStatus.None;

        /// <summary>
        /// Gets or sets the date and time processing began on this item.
        /// </summary>
        public DateTimeOffset? StartProcessing { get; set; }

        /// <summary>
        /// Gets or sets the date and time processing finished on this queue item.
        /// </summary>
        /// <remarks>
        /// If the queue item is abandoned, this will reflect the time that the item was
        /// marked as abandoned.
        /// </remarks>
        public DateTimeOffset? EndProcessing { get; set; }

        /// <summary>
        /// Gets the failed queue item the current queue item is retrying.
        /// </summary>
        public QueueItem? Ancestor { get; init; }

        /// <summary>
        /// Gets the current retry iteration.
        /// </summary>
        public int? RetryNumber { get; init; }

        /// <summary>
        /// Gets or sets a JSON string containing the data stored in this queue item.
        /// </summary>
        public string? QueueData { get; set; }

        /// <summary>
        /// Gets or sets the JSON data contained in this record.
        /// </summary>
        public JsonDocument? JsonValueWrapper
        {
            get { return QueueData is null ? null : JsonDocument.Parse(QueueData); }
            set { QueueData = value?.ToString(); }
        }

        /// <summary>
        /// Gets or sets the date and time this queue item was last modified.
        /// </summary>
        public DateTimeOffset? LastModificationTime { get; set; }

        /// <summary>
        /// Gets or sets the Active Directory user id of the user who last updated the item.
        /// </summary>
        public Guid? LastModifierId { get; set; }

        /// <summary>
        /// Gets the date and time this queue item was created.
        /// </summary>
        public required DateTimeOffset CreationTime { get; init; }

        /// <summary>
        /// Gets the Active Directory user id of the user who created the item.
        /// </summary>
        public required Guid CreatorId { get; init; }

        /// <summary>
        /// Gets or sets the date and time after which the queue item becomes available for work.
        /// </summary>
        public DateTimeOffset? DeferDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time by which the queue item should be processed.
        /// </summary>
        public DateTimeOffset? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the current progress of the queue item.
        /// </summary>
        public string? Progress { get; set; }

        /// <summary>
        /// Gets or sets any exit information for the queue item.
        /// </summary>
        public string? Output { get; set; }

        /// <summary>
        /// Gets or sets the kind of error that caused this queue item to fail.
        /// </summary>
        /// <remarks>If <see cref="Status"/> is <see cref="Status.Failed"/>,
        /// <see cref="Status.Abandoned"/>, or <see cref="Status.Retried"/>,
        /// this value will not be null.</remarks>
        /// <example>NotFoundError.</example>
        public string? ProcessingExceptionType { get; set; }

        /// <summary>
        /// Gets or sets the reason this queue item failed.
        /// </summary>
        /// <remarks>If <see cref="Status"/> is <see cref="Status.Failed"/>,
        /// <see cref="Status.Abandoned"/>, or <see cref="Status.Retried"/>,
        /// this value will not be null.</remarks>
        /// <example>Could not find a value for Person.Name.</example>
        public string? ProcessingExceptionReason { get; set; }

        /// <summary>
        /// Gets or sets additional details, such as a stack trace, as to the reason the queue item failed.
        /// </summary>
        /// <remarks>If <see cref="Status"/> is <see cref="Status.Failed"/>,
        /// <see cref="Status.Abandoned"/>, or <see cref="Status.Retried"/>,
        /// this value will not be null.</remarks>
        public string? ProcessingExceptionDetails { get; set; }

        /// <summary>
        /// Gets the reference for this queue item.
        /// </summary>
        /// <remarks>
        /// If the queue is configured to require a unique queue item, this
        /// field will not be null.
        /// </remarks>
        public string? Reference { get; init; }

        /// <summary>
        /// Gets or sets the Active Directory user id of the user who reviewed this queue item.
        /// </summary>
        public Guid? ReviewerUserId { get; set; }
    }
}
