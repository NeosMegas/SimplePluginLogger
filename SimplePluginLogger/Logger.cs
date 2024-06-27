using System;
using System.Diagnostics;
using System.IO;

namespace SimplePluginLogger
{
    public static class Logger
    {
        private static string logFilePath = Path.GetTempFileName();
        public static string LogFilePath { get => logFilePath; }

        /// <summary>
        /// Запись сообщения лога во временный файл
        /// </summary>
        /// <param name="message">Сообщение</param>
        public static void Log(string message)
        {
            using (StreamWriter sr = File.AppendText(logFilePath))
                sr.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff ") + message);
        }

        /// <summary>
        /// Открыть временный файл (например, в блокноте)
        /// </summary>
        public static void OpenLogFile() => Process.Start(logFilePath);
    }
}
