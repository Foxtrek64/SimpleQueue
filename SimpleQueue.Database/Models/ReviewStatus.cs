//
//  ReviewStatus.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Enumerates the current review status.
    /// </summary>
    public enum ReviewStatus
    {
        /// <summary>
        /// This is the default status and is set on all items of any status.
        /// </summary>
        None = 0,

        /// <summary>
        /// The item has failed with an exception and is in the process of being reviewed.
        /// This status has no implications other than changing the display value.
        /// </summary>
        InReview = 1,

        /// <summary>
        /// A user has marked an item as verified. This is used to indicate that there is no
        /// further work to be done with this queue item. For instance, a business user may have
        /// elected to work this queue item manually rather than having the bot retry. A queue item
        /// cannot be retried after setting this status.
        /// </summary>
        Verified = 2,

        /// <summary>
        /// The item has been reviewed by a user and manually marked for retry. As a reqult, a new queue item
        /// with the status of New is created. This is displayed in the ITem Details window of the indicated
        /// transaction.
        /// </summary>
        Retried = 3
    }
}
