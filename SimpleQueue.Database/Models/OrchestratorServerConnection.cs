//
//  OrchestratorServerConnection.cs
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

// Required keyword goes after public.
#pragma warning disable SA1206 // Declaration keywords should follow order

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// A class which represents a connection to an Orchestrator server.
    /// </summary>
    public sealed record class OrchestratorServerConnection
    {
        /// <summary>
        /// Gets the unique id of this connection.
        /// </summary>
        public required int Id { get; init; }

        /// <summary>
        /// Gets or sets the address for this server.
        /// </summary>
        public required Uri ServerAddress { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant to connect to.
        /// </summary>
        public required string TenancyName { get; set; } = "Default";

        /// <summary>
        /// Gets or sets the username for authentication.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the password for authentication.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the client id for authentication.
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret for authentication.
        /// </summary>
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets a space-deliited set of scopes.
        /// </summary>
        public string? Scope { get; set; }
    }
}
