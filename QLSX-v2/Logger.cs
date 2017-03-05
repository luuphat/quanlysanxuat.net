using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLSX
{
    public enum LogLevel
    {
        DEBUG = 1,
        ERROR = 2,
        FATAL = 3,
        INFO = 4,
        WARN = 5
    }

    public class Logger
    {
        //private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static Logger()
        {
            //BasicConfigurator.Configure();
            //XmlConfigurator.Configure();
        }
        
        public static void WriteLog(LogLevel logLevel, String log)
        {
            //if (logLevel.Equals(LogLevel.DEBUG))
            //    logger.Debug(log);
            //else if (logLevel.Equals(LogLevel.ERROR))
            //    logger.Error(log);
            //else if (logLevel.Equals(LogLevel.FATAL))
            //    logger.Fatal(log);
            //else if (logLevel.Equals(LogLevel.INFO))
            //    logger.Info(log);
            //else if (logLevel.Equals(LogLevel.WARN))
            //    logger.Warn(log);
            System.Diagnostics.Trace.Write(log);
        }
    }
}
