using System;
using System.IO;
using System.Threading.Tasks;

namespace ControllerScouting.Utilities
{
    public class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..", "log.txt");

        public static async Task Erase()
        {
            await Task.Run(() => File.WriteAllText(logFilePath, string.Empty));
        }

        public static async Task Log(string m)
        {
            // Write string m into file log.txt
            await Task.Run(() => File.AppendAllText(logFilePath, m + Environment.NewLine));
        }
    }
}