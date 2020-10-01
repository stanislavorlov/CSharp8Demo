using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8
{
    internal sealed class AsynchronousStreams
    {
        public static void Run()
        {
            var cts = new CancellationTokenSource();

            Task.Factory.StartNew(async () =>
            {
                await foreach (var number in GenerateSequence(10)
                    .WithCancellation(cts.Token))
                {
                    Console.WriteLine(number);
                }
            }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }

        public static async IAsyncEnumerable<int> GenerateSequence(int count, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(i, cancellationToken);
                yield return i;
            }
        }
    }
}
