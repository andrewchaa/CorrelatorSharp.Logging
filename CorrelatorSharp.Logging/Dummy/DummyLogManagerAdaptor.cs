using System;
using System.Linq;

namespace CorrelatorSharp.Logging.Dummy
{
    internal class DummyLogManagerAdaptor : ILogManagerAdaptor
    {
        public readonly static DummyLogManagerAdaptor Instance = new DummyLogManagerAdaptor();

        public ILogger GetCurrentClassLogger()
        {
            return new DummyLoggerAdaptor("DummyLogger");
        }

        public ILogger GetLogger(string name)
        {
            return new DummyLoggerAdaptor(name);
        }
    }
}
