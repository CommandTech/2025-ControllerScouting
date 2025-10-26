using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ControllerScouting.Utilities
{
    public class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..", "log.txt");
        private static readonly SemaphoreSlim fileLock = new (1, 1);

        public static async Task Erase()
        {
            await fileLock.WaitAsync();
            try
            {
                await Task.Run(() => File.WriteAllText(logFilePath, string.Empty));
            }
            finally
            {
                fileLock.Release();
            }
        }

        public static async Task Log(string m)
        {
            await fileLock.WaitAsync();
            try
            {
                // Write string m into file log.txt
                await Task.Run(() => File.AppendAllText(logFilePath, m + Environment.NewLine));
            }
            finally
            {
                fileLock.Release();
            }
}
    }
}