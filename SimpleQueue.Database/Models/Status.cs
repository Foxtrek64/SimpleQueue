//
//  Status.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Enumerates the status of a queue item.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The queue item is new and ready for processing.
        /// </summary>
        New = 0,

        /// <summary>
        /// The queue item is currently being processed.
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// Processing the queue item failed.
        /// </summary>
        Failed = 2,

        /// <summary>
        /// Processing the queue item was successful.
        /// </summary>
        Successful = 3,

        /// <summary>
        /// The item remained in the In Progress status for 24 hours without a status update.
        /// </summary>
        Abandoned = 4,

        /// <summary>
        /// The item failed with an exception and a new queue item was created to retry.
        /// </summary>
        Retried = 5,

        /// <summary>
        /// The item was manually deleted and can no longer be processed.
        /// </summary>
        Deleted = 6,
    }
}
