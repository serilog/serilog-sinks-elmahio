﻿using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.Sinks.ElmahIo
{
    /// <summary>
    /// Provides ElmahIoSink with configurable options
    /// </summary>
    public class ElmahIoSinkOptions
    {
        /// <summary>
        /// An API key able to write messages to elmah.io (enable the Messages - Write permission).
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The ID of the log to store messages from Serilog.
        /// </summary>
        public Guid LogId { get; set; }

        ///<summary>
        /// Supplies culture-specific formatting information, or null.
        /// </summary>
        public IFormatProvider FormatProvider { get; set; }

        ///<summary>
        /// The maximum number of events to post in a single batch. Defaults to: 50.
        /// </summary>
        public int BatchPostingLimit { get; set; }

        ///<summary>
        /// The time to wait between checking for event batches. Defaults to 2 seconds.
        /// </summary>
        public TimeSpan Period { get; set; }

        /// <summary>
        /// The minimum log event level required in order to write an event to the sink.
        /// </summary>
        public LogEventLevel? MinimumLogEventLevel { get; set; }

        /// <summary>
        /// A switch allowing the pass-through minimum level to be changed at runtime.
        /// </summary>
        public LoggingLevelSwitch LevelSwitch { get; set; }

        /// <summary>
        /// Creates a new options instance. Period will be set to 2 seconds and
        /// BatchPostingLimit to 50 unless set manually afterwards.
        /// </summary>
        public ElmahIoSinkOptions()
        {
            Period = TimeSpan.FromSeconds(2);
            BatchPostingLimit = 50;
        }
    }
}