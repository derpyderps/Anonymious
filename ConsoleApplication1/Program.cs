using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            log.Error("ERROR MESSAGE");
            log.Info("TESTING LOG4NET");
            log.Warn("WARNING");
            log.Info(" LOG4NET");
            log.Info("Messages are never constantly numered...");
            log.Warn(log.Logger.Name + " = this logger ");
        }
    }
}
