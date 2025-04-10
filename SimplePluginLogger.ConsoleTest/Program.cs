using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePluginLogger.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("test1");
            logger.OpenLogFile();
        }
    }
}
