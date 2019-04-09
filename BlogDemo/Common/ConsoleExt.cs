using System;
using System.Threading;

namespace Common
{
    public class ConsoleExt
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine(GetCurrentTimeAndThreadId() + message);
        }

        private static string GetCurrentTimeAndThreadId()
        {
            return $"(Time:{DateTime.Now},Thread:{Thread.CurrentThread.ManagedThreadId}):";
        }
    }
}
