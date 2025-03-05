using System;
using System.IO;

namespace ControllerScouting.Utilities
{
    public class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..", "log.txt");

        public static void Erase()
        {
            File.WriteAllText(logFilePath, string.Empty);
        }

        public static void Log(string m)
        {
            // Write string m into file log.txt
            File.AppendAllText(logFilePath, m + Environment.NewLine);
        }
    }
}