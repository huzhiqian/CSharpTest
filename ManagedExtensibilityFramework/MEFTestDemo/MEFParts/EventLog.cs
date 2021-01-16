using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;


    [Export(typeof(ILogger))]
    [ExportMetadata("Guid","{DA940BA4-743A-4A6D-9A47-E2D25C4E2B53}")]
    public class EventLog : ILogger
    {
        public void WriteLog(string logInfo)
        {
            Console.WriteLine($"Event Log:{logInfo}");
        }
    }

