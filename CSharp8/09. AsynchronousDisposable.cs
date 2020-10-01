using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8
{
    internal sealed class AsynchronousDisposable
    {
        public static void Run()
        {
            Task.Factory.StartNew(async () =>
            {
                await using var resource = new AsyncResource();
                await resource.PerformAsync();

            }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        internal sealed class AsyncResource : IAsyncDisposable
        {
            public async Task PerformAsync()
            {
                Console.WriteLine("Performing some asynchronous work...");
                await Task.Delay(5000);
                Console.WriteLine("Done");
            }

            public async ValueTask DisposeAsync()
            {
                Console.WriteLine("Disposing asynchronously");
                await Task.Delay(5000);
                Console.WriteLine("Done");
            }
        }
    }
}
