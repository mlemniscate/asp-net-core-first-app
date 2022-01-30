using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.Adapter
{
    internal interface ILogger
    {
        void Log();
    }

    public class MyLogger : ILogger
    {
        public void Log()
        {
            
        }
    }

    public class SpecialLogger
    {
        public void DoLog()
        {
            // This logger has a lot more features but don't has the same interface
            // that our MyLogger has
            // So we instead of replacing SpecialLogger in every where of project we
            // can use Adapter pattern
        }
    }

    // This is class adapter when we want to use an adapter to a interface
    public class SpecialLoggerAdapter : SpecialLogger, ILogger
    {
        public void Log()
        {
            DoLog();
        }
    }

    // This is object adapter we don't have multiple inheritance
    public class SpecialLoggerAdapter2 : ILogger
    {
        private SpecialLogger logger = new SpecialLogger();
        public void Log()
        {
            logger.DoLog();
        }
    }
}
