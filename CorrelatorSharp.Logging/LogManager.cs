using System;
using System.Diagnostics;

namespace CorrelatorSharp.Logging
{
    public static class LogManager
    {
        public static ILogger GetCurrentClassLogger()
        {
            var frame = new StackFrame(1, false);
            return GetLogger(frame.GetMethod().DeclaringType.FullName);
        }

        public static ILogger GetLogger(string name)
        {
            return LoggingConfiguration.LogManager.GetLogger(name);
        }
    }
}
