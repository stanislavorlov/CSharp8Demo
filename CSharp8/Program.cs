namespace CSharp8
{
    class Program
    {
        static void Main()
        {
            //0. Attributes on Properties
            AttributesOnProperties.Run();

            //1. Readonly members
            ReadonlyMembers.Run();

            //2. Default interface methods
            DefaultInterfaceMethods.Run();

            //3. Patterns matching
            PatternMatching.Run();

            //4. Using Declarations
            UsingDeclarations.Run();

            //5. Static Local Functions
            StaticLocalFunctions.Run();

            //6. Disposable ref structs
            DisposableRefStructs.Run();

            //7. Nullable Reference Types
            NullableReferenceTypes.Run();

            //8. Asynchronous streams
            AsynchronousStreams.Run();

            //9. Asynchronous disposable
            AsynchronousDisposable.Run();

            //10. Indeces And Ranges
            IndecesAndRanges.Run();

            //11. Null-coalescing assignment
            NullCoalescingAssignment.Run();

            //12. Nested Stackalloc
            NestedStackalloc.Run();

            //13. Enhancement of interpolated verbatim strings
            InterpolatedVerbatimStringsEnhancement.Run();
        }
    }
}
