using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;


namespace MEFTestParts
{
    [Export(typeof(ILogger))]
    [ExportMetadata("guid","{D8CD4E3B-0427-47B6-B467-5C146F3C721F}")]
    public class DebugLog : ILogger
    {
        public void WriteLog(string logInfo)
        {
            Console.WriteLine($"Debug log:{logInfo}");
        }
    }
}
