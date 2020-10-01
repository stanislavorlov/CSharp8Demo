using System;

namespace CSharp8
{
    internal sealed class NestedStackalloc
    {
        public static void Run()
        {
            Span<int> span = stackalloc int[5];
            TestMethod(span);

            //Only valid in C# 8
            TestMethod(stackalloc int[5]);

            Span<Coords<int>> coordinates = stackalloc Coords<int>[]
            { 
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 1, Y = 2 }
            };
        }

        private static void TestMethod(Span<int> span) { }

        private struct Coords<T>
        {
            public T X { get; set; }
            public T Y { get; set; }
        }
    }
}
