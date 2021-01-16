using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public interface IMetaData
{
    string Guid { get; }
}
public interface ILogger
    {
        void WriteLog(string logInfo);
    }



