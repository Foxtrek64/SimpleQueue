//
//  Priority.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Enumerates the priority of a queue item.
    /// </summary>
    public enum Priority
    {
        /// <summary>
        /// Default. No priority.
        /// </summary>
        None = 0,

        /// <summary>
        /// Low priority.
        /// </summary>
        Low = 1,

        /// <summary>
        /// Medium priority.
        /// </summary>
        Medium = 2,

        /// <summary>
        /// High priority.
        /// </summary>
        High = 3,

        /// <summary>
        /// Very high priority.
        /// </summary>
        VeryHigh = 4
    }
}
