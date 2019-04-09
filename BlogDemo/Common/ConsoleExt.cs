using System;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class ConsoleExt
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine(GetCurrentTimeAndThreadId() + message);
        }

        public static async void WriteLineAsync(string message)
        {
            await Task.Run(() => Console.WriteLine(GetCurrentTimeAndThreadId() + message));
        }

        private static string GetCurrentTimeAndThreadId()
        {
            return $"(Time:{DateTime.Now.ToString("hh:mm:ss.ffffff")},Thread:{Thread.CurrentThread.ManagedThreadId}):";
        }
    }
}
