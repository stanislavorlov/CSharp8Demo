using System;

namespace CSharp8
{
    internal class DisposableRefStructs
    {
        public static void Run()
        {
            using var disposableStruct = new DisposableStruct();
        }

        /// <summary>
        /// Ref structs can now be disposable without implementing the IDisposable interface, simply by having a Dispose method in them.
        /// </summary>
        public ref struct DisposableStruct
        {
            public void Dispose()
            {
                Console.WriteLine("disposed");
            }
        }
    }
}
