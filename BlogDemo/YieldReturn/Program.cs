using Common;
using System;
using System.Collections.Generic;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 5;
            ConsoleExt.WriteLine("Sum with yield starting.");
            foreach (var i in SumFromOneToCountYield(count))
            {
                ConsoleExt.WriteLine($"Yield sum: {i}");
            }
            ConsoleExt.WriteLine("Sum with yield completed.");

            ConsoleExt.WriteLine("################################################");
            ConsoleExt.WriteLine(Environment.NewLine);
        }
        static IEnumerable<int> SumFromOneToCountYield(int count)
        {
            ConsoleExt.WriteLine("SumFromOneToCountYield called!");

            var sum = 0;
            for (var i = 0; i <= count; i++)
            {
                sum = sum + i;

                yield return sum;
            }
        }
    }
}
