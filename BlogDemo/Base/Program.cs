using Common;
using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 5;
            ConsoleExt.WriteLine($"Starting the application with count: {count}!");
            ConsoleExt.WriteLine("Classic sum starting.");
            ConsoleExt.WriteLine($"Classic sum result: {SumFromOneToCount(count)}");
            ConsoleExt.WriteLine("Classic sum completed.");
            ConsoleExt.WriteLine("################################################");
        }

        static int SumFromOneToCount(int count)
        {
            ConsoleExt.WriteLine("SumFromOneToCount called!");

            var sum = 0;
            for (var i = 0; i <= count; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
