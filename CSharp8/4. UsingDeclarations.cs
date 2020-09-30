using System;
using System.IO;

namespace CSharp8
{
    internal sealed class UsingDeclarations
    {
        public static void Run()
        {
            using var stream = new MemoryStream();
            stream.Write(ReadOnlySpan<byte>.Empty);
        }
    }
}