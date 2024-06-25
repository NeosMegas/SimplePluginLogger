using System;
using System.Diagnostics;
using System.IO;

namespace SimplePluginLogger
{
    public static class PluginLogger
    {
        private static string logFilePath = Path.GetTempFileName();
        public static string LogFilePath { get => logFilePath; }

        public static void Log(string message)
        {
            using (StreamWriter sr = File.AppendText(logFilePath))
                sr.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff ") + message);
        }

        public static void OpenLogFile() => Process.Start(logFilePath);
    }
}
