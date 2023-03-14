//
//  BotIntegrationDefinition.cs
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
using System.Text.Json;
using System.Threading.Tasks;

// Required keyword goes after public.
#pragma warning disable SA1206 // Declaration keywords should follow order

namespace SimpleQueue.Database.Models
{
    /// <summary>
    /// Represents an integration which can start a bot.
    /// </summary>
    public sealed record class BotIntegrationDefinition
    {
        /// <summary>
        /// Gets the unique id for this integration.
        /// </summary>
        public required int Id { get; init; }

        /// <summary>
        /// Gets or sets the connection to the Orchestrator server.
        /// </summary>
        public required OrchestratorServerConnection ServerConnection { get; set; }

        /// <summary>
        /// Gets or sets the unique name of the process to execute on the Orchestrator server.
        /// </summary>
        public required string ProcessString { get; set; }

        /// <summary>
        /// Gets or sets the unique id of the bot on which to run the process on the Orchestrator server.
        /// </summary>
        public required int BotId { get; set; }

        /// <summary>
        /// Gets or sets a json-encoded string containing the input parameters.
        /// </summary>
        public string? InputParameters { get; set; }

        /// <summary>
        /// Gets or sets the JSON data contained in this record.
        /// </summary>
        public JsonDocument? InputParametersDocument
        {
            get { return InputParameters is null ? null : JsonDocument.Parse(InputParameters); }
            set { InputParameters = value?.ToString(); }
        }
    }
}
