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
            PluginLogger.Log("test1");
            PluginLogger.OpenLogFile();
        }
    }
}
