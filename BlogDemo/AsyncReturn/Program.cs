using Common;
using System;
using System.Threading.Tasks;

namespace AsyncReturn
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const int count = 5;
            ConsoleExt.WriteLine("async example starting.");
            // Sum runs asynchronously! Not enough. We need sum to be async with lazy behavior.
            var result = await SumFromOneToCountAsync(count);
            ConsoleExt.WriteLine("async Result: " + result);
            ConsoleExt.WriteLine("async completed.");

            ConsoleExt.WriteLine("################################################");
            ConsoleExt.WriteLine(Environment.NewLine);
        }
        static async Task<int> SumFromOneToCountAsync(int count)
        {
            ConsoleExt.WriteLine("SumFromOneToCountAsync called!");

            var result = await Task.Run(() =>
            {
                var sum = 0;

                for (var i = 0; i <= count; i++)
                {
                    sum = sum + i;
                }
                return sum;
            });

            return result;
        }
    }
}
