using System;
using System.Reflection;
using CSharp8;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
